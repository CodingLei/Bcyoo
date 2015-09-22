//自行封装的lhg弹窗，简化参数或者扩展一些其他功能

function lhgShowDialog(title, pageName, page, width, height) {
    var dg = new J.dialog({ id: pageName, page: page, cover: true, autoPos: { left: 'center', top: 'center' }, width: width, height: height, title: title, iconTitle: false, btnBar: false });
    dg.ShowDialog();
}


