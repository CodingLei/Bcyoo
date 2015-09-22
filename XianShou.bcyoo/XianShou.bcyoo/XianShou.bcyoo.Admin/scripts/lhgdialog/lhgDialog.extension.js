
//消息图标集合，0:无 1:提示 2:成功 3:失败 4:确认
var _iconArrays = [null, 'alert.gif', 'success.gif', 'error.gif', 'prompt.gif'];

$.getOpener = function () {
    /// <summary>
    /// 判断要打开窗口的对象
    /// 如果frameElement不为空，则说明是打开第二层以上弹窗，也就是弹窗中再打开弹窗
    /// frameElement为空，说明是打开第一层弹窗，也就是从底层页面中打开弹窗
    ///</summary>

    var api = null, W = window;
    if (frameElement) {
        //需要获得父页面的api来进行递归传递
        api = frameElement.api;
        if (!api && parent && parent.frameElement) api = parent.frameElement.api;
        if (api) W = api.opener;
    }
    return { api: api, oper: W };
};


$.showModalDialog = function (url, width, height, title, id, dgcallback, options) {
    /// <summary>弹出url内容页窗口</summary>
    /// <param name="url" type="String">内容页的url地址</param>
    /// <param name="width" type="Number">设置窗口的宽度</param>
    /// <param name="height" type="Number">设置窗口的高度</param>
    /// <param name="title" type="String">窗口的标题文本</param>
    /// <param name="id" type="String">设定对话框唯一标识，防止重复弹出</param>
    /// <param name="dgcallback" type="function">回调函数，配合在窗口页里调用returnDialogResult(data)，可以向父页面回写数据和处理</param>
    /// <param name="options" type="object">扩展属性，设置窗口其他属性，详见lhgdialog4.x的api文档</param>
    /// <returns type="$.dialog" />

    if (url.indexOf("?") == -1) {
        url += "?";
    }
    url += "&vDate=" + new Date().getTime();

    var dg = $.getOpener(),
        opts = options || {},
        config = {
            id: id,
            title: title,
            content: 'url:' + url,
            width: width || 'auto',
            height: height || 'auto',
            lock: true,
            max: false,
            min: false,
            dgcallback: dgcallback,
            parent: dg.api
        };
    for (var i in opts) {
        if (config[i] === undefined) config[i] = opts[i];
    }
    return dg.oper.$.dialog(config);
};

$.showContentDialog = function (content, width, height, title, id, lock, dgcallback, options) {
    /// <summary>带动画效果的弹出HTML内容窗口</summary>
    /// <param name="content" type="String">窗口内容，支持HTML格式</param>
    /// <param name="width" type="Number">设置窗口的宽度</param>
    /// <param name="height" type="Number">设置窗口的高度</param>
    /// <param name="title" type="String">窗口的标题文本</param>
    /// <param name="id" type="String">设定对话框唯一标识，防止重复弹出</param>
    /// <param name="lock" type="Boolean">是否开启锁屏，默认false</param>
    /// <param name="dgcallback" type="function">回调函数，配合在窗口页里调用returnDialogResult(data)，可以向父页面回写数据和处理</param>
    /// <param name="options" type="object">扩展属性，设置窗口其他属性，详见lhgdialog4.x的api文档</param>
    /// <returns type="$.dialog" />

    if (content.substring(0, 4) == "url:") {
        //如果开头有"url:"字符前缀，则过滤掉
        content = content.substring(4, content.length);
    }
    var dg = $.getOpener(),
        duration = 400, /*动画时长*/
        opts = options || {},
        api, aConfig, wrap,
        config = {
            id: id,
            title: title,
            content: content,
            width: width || 'auto',
            height: height || 'auto',
            lock: lock || false,
            min: false,
            max: false,
            dgcallback: dgcallback,
            parent: dg.api,
            init: function (here) {
                api = this;
                aConfig = api.config;
                wrap = api.DOM.wrap;

                wrap.css({ opacity: .0 })
                    .animate({ opacity: 1.0 }, duration, function () {
                        opts.init && opts.init.call(api, here);
                    });
            },
            close: function (here) {
                wrap.animate({ opacity: .0 }, duration, function () {
                    opts.close && opts.close.call(this, here);
                    aConfig.close = $.noop;
                    api.close();
                });
                return false;
            }
        };
    for (var i in opts) {
        if (config[i] === undefined) config[i] = opts[i];
    }
    return dg.oper.$.dialog(config);
};


$.notice = function (content, width, height, title, id, icon, time, duration) {
    /// <summary>带动画效果的右下角浮动消息窗口</summary>
    /// <param name="content" type="String">窗口内容，支持HTML格式</param>
    /// <param name="width" type="Number">设置窗口的宽度</param>
    /// <param name="height" type="Number">设置窗口的高度</param>
    /// <param name="title" type="String">窗口的标题文本</param>
    /// <param name="id" type="String">设定对话框唯一标识，防止重复弹出</param>
    /// <param name="icon" type="Number">消息图标，0=无 1=提示 2=成功 3=失败 4=确认，默认0</param>
    /// <param name="time" type="Number">设置对话框显示时间，到时自动关闭，单位秒，默认3</param>
    /// <param name="duration" type="Number">动画时长，单位毫秒，默认800</param>
    /// <returns type="$.dialog" />

    duration = duration || 600;
    var opts = { id: id, title: title || '消息提示', width: width, height: height, content: content, time: time || 3 },
       api, aConfig, hide, wrap, top;
    var config = {
        left: '100%',
        top: '100%',
        icon: _iconArrays[icon || 0],
        zIndex: $.getOpener().oper.$.dialog.setting.zIndex,
        fixed: true,
        drag: false,
        resize: false,
        max: false,
        min: false,
        esc: false,
        init: function (here) {
            api = this;
            aConfig = api.config;
            wrap = api.DOM.wrap;
            top = parseInt(wrap[0].style.top);
            hide = top + wrap[0].offsetHeight;
            wrap.css({ top: hide + 'px', opacity: .0 })
                .animate({ top: top + 'px', opacity: 1.0 }, duration, function () {
                    opts.init && opts.init.call(api, here);
                });
        },
        close: function (here) {
            wrap.animate({ top: hide + 'px', opacity: .0 }, duration, function () {
                opts.close && opts.close.call(this, here);
                aConfig.close = $.noop;
                api.close();
            });
            return false;
        }
    };
    for (var i in opts) {
        if (config[i] === undefined) config[i] = opts[i];
    }
    return $.dialog(config);
};

$.alert = function (message, icon, callback) {
    /// <summary>带动画效果的消息提示窗口</summary>
    /// <param name="message" type="String">消息内容，支持HTML格式</param>
    /// <param name="icon" type="Number">消息图标，1=提示 2=成功 3=失败 4=确认，默认1</param>
    /// <param name="callback" type="function">窗口关闭时执行的回调函数</param>
    /// <returns type="$.dialog" />

    var opts = {
        fixed: true,
        ok: true,
        resize: false,
        icon: _iconArrays[(icon == 0 ? 1 : icon) || 1],
        close: function() {
            callback && $.extend({ fun: callback })
                && window.setTimeout("$.fun()", 1);
        }
    };
    return $.showContentDialog(message, null, null, '消息提示', 'Alert', true, null, opts);
};

$.confirm = function (message, yes, no) {
    /// <summary>
    /// 带动画效果的确认提示窗口
    /// </summary>
    /// <param name="message" type="String">消息内容，支持HTML格式</param>
    /// <param name="yes" type="function">确定按钮回调函数</param>
    /// <param name="no" type="function">取消按钮回调函数</param>
    /// <returns type="$.dialog" />
    
    var opts = {
        fixed: true,
        lock: true,
        resize: false,
        icon: _iconArrays[1],
        ok: function (here) {
            return yes.call(this, here);
        },
        cancel: function (here) {
            return no && no.call(this, here);
        }
    };
    return $.showContentDialog(message, null, null, '确认提示', 'Confirm', true, null, opts);
};



$.returnDialogResult = function (data, isCloseDialog) {
    /// <summary>
    /// lhgdialog窗口页向父页面回写数据方法
    /// 如果父页面未声明回调函数，则不回写数据，只判断是否关闭
    /// 如果在非lhgdialog窗口内，则该方法失效
    /// </summary>
    /// <param name="data">需要回写的数据，类型由父页面和窗口页约定</param>
    /// <param name="isCloseDialog" type="Boolean">回写后是否直接关闭窗口，默认true，设置false可以不关闭以便多次回写</param>

    if (frameElement != null) {
        var api = frameElement.api;
        if (!api && parent && parent.frameElement) api = parent.frameElement.api;
        api && api.config && api.config.dgcallback && api.config.dgcallback(data);
        if (isCloseDialog == null || isCloseDialog) {
            $.closeDialog();
        }
    }
};

$.closeDialog = function () {
    /// <summary>
    /// 关闭对话框，兼容lhgdialog和js自带对话框
    /// </summary>
    if (frameElement) {
        var api = frameElement.api;
        if (!api && parent && parent.frameElement) api = parent.frameElement.api;
        api && api.time(0.1);
        return;
    }
    window.close();
};

$.tips = function (content, icon, lock, callback, time) {
    /// <summary>带动画效果的中央浮动消息提示</summary>
    /// <param name="content" type="String">窗口内容，支持HTML格式</param>
    /// <param name="icon" type="Number">消息图标，0=无 1=提示 2=成功 3=失败 4=确认，默认0</param>
    /// <param name="lock" type="Boolean">是否开启锁屏，默认false</param>
    /// <param name="callback" type="function">消息提示层关闭时执行的回调函数</param>
    /// <param name="time" type="Number">设置对话框显示时间，到时自动关闭，单位秒，默认1.5秒</param>

    $.showContentDialog(
        content, null, null, false, 'Tips', lock, null, {
            fixed: true,
            icon: _iconArrays[icon || 0],
            resize: false,
            close: function () {
                callback && $.extend({ fun: callback })
                    && window.setTimeout("$.fun()", 1);
            }
        }).time(time || 1.5);
};

$.loadingTips = function(message) {
    /// <summary>开启数据加载遮罩层</summary>
    /// <param name="message" type="String">遮罩提示内容，支持HTML格式</param>
    /// <returns type="$.dialog" />

    return $.showContentDialog(
        message || '数据加载中...', null, null, false, 'Tips', true, null, {
            fixed: true,
            icon: 'loading.gif',
            resize: false
        });
};

$.loadingClose = function (time, message, icon, callback) {
    /// <summary>关闭数据加载遮罩层</summary>
    /// <param name="time" type="Number">设置对话框显示时间，到时自动关闭，单位秒，默认直接关闭</param>
    /// <param name="message" type="String">如果设置了time参数，则在关闭前会显示的内容，支持HTML格式</param>
    /// <param name="icon" type="Number">消息图标，0=无 1=提示 2=成功 3=失败 4=确认，默认0</param>
    /// <param name="callback" type="function">loading层关闭时执行的回调函数</param>

    var op = $.getOpener(),
        dg = op.api ? op.api.get('Tips', 1) : $.dialog.list['Tips'];
    if (dg) {
        var duration = 400, /*动画时长*/
            //重写关闭回调函数
            close = function () {
                dg.DOM.wrap.animate({ opacity: .0 }, duration, function () {
                    callback && $.extend({ fun: callback }) && window.setTimeout("$.fun()", 1);
                    dg.config.close = $.noop;
                    dg.close();
                });
                return false;
            };
        if (time && time > 0) {
            var icons = _iconArrays[icon || 0];
            dg.content(message || '数据加载完毕')
                .time(time, function () {
                    if (icons) {
                        dg.DOM.icon[0].innerHTML = '<img src="' + dg.config.path + 'skins/icons/' + icons + '" class="ui_icon_bg"/>';
                        dg.DOM.icon[0].style.display = '';
                    } else {
                        dg.DOM.icon[0].style.display = 'none';
                    }
                    dg.config.close = close;
                });
        } else {
            dg.time(0.1, function () {
                dg.config.close = close;
            });
        }
    }
};