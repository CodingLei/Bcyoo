//----------------------------------------------------------------------
//修改人:wanggq
//修改内容：改动原来的formPager，不用form也可以提交，通过url分页
//修改时间：2013-5-22 10:56:07
//---------------------------------------------------------------------
window.formPager = function (objlink) {
    /// <summary>将链接转换成表单提交</summary>
    /// <param name="objlink" type="object">要转换的链接DOM对象</param>

    var frm = $(objlink).closest('form');
    if (frm.length > 0) {
        var actionValue = frm.attr("action");
        frm.attr("action", objlink.href).submit();
        frm.attr("action", actionValue);
        return false;
    }
    //form找不到，还是会按照一般的链接跳转，不会有影响
    return true;
};

window.multiAjaxSubmit = function () {
    /// <summary>多重Ajax提交，让页面可以同时一个按钮提交多个Ajax.Form异步调用</summary>

    var frm = $(this).closest('form');
    var fields = frm.serializeArray();
    $("form").not(frm).each(function () {
        var objfrm = $(this);
        $.each(fields, function (i, field) {
            if (objfrm.children("#" + field.name).length <= 0) {
                objfrm.append("<input type='hidden' id='" + field.name + "' name='" + field.name + "' value='' />");
            }
            objfrm.children("#" + field.name).val(field.value);
        });
        objfrm.submit();
    });
};

window.dataExport = function (objbtn, url, target) {
    /// <summary>更灵活的导出方法，不必再写一大串js来实现了</summary>
    /// <param name="objbtn" type="object">触发导出方法的DOM对象</param>
    /// <param name="url" type="String">导出的具体调用地址</param>
    /// <param name="target" type="String">目标类型，如_blank、_self等</param>

    //先在body添加一个专门用来执行导出excel调用的form
    var frmExport = $("<form></form>", {
        'id': 'frmExport',
        'method': 'post',
        'action': url,
        'target': target,
        'style': 'display:none'
    }).appendTo($("body"));
    //找到里按钮最近的form，按约定也就是包含导出按钮的form
    var frm = $(objbtn).closest('form');
    //取得这个form元素里的所有表单元素
    var fields = frm.serializeArray();
    //便后遍历fiels，将所有值添加到导出的form里
    $.each(fields, function (i, field) {
        frmExport.append($("<input>", { "type": "hidden", "name": field.name, "value": field.value }));
    });
    //提交导出的form
    frmExport.submit();
    //提交完毕后，移除该form
    frmExport.remove();
};

window.redirectPost = function (url, params, target) {
    /// <summary>post跳转地址，并且带过去指定参数集合</summary>
    /// <param name="url" type="String">跳转的的地址</param>
    /// <param name="params" type="object">参数集合</param>
    /// <param name="target" type="String">目标类型，如_blank、_self等</param>

    //先在body添加一个专门用来执行导出excel调用的form
    var frmRedirect = $("<form></form>", {
        'id': 'redirectPost',
        'method': 'post',
        'action': url,
        'target': target,
        'style': 'display:none'
    }).appendTo($("body"));
    //便后遍历fiels，将所有值添加到导出的form里
    $.each(params, function (name, value) {
        frmRedirect.append($("<input>", { "type": "hidden", "name": name, "value": value }));
    });
    //提交导出的form
    frmRedirect.submit();
    //提交完毕后，移除该form
    frmRedirect.remove();
}

$(document).ready(function () {
    /// <summary>页面异步加载所有ajaxMessage标记的调用信息</summary>

    $(".ajaxMessage").each(function () {
        var obj = $(this);
        $.get(obj.attr("ajax-action"), function (message) {
            obj.html(message);
        });
    });
})