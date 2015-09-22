//maxSize:分页控件显示页码数
//itemsPerPage:单页条数
//bigCurrentPage:默认页码
//OrderByDesc:排序字段
//getDataUrl:请求url
//eventFunction：数据异步请求后需要执行的事件
$.PageInit=function($scope, $http, options) {
    var defaultVal = {
        maxSize: 5,//分页控件显示页码数
        itemsPerPage: 10,//单页条数
        bigCurrentPage: 1,//默认页码
        OrderByDesc: "AddTime"
    };
    var obj = $.extend(defaultVal, options);
    $scope.maxSize = obj.maxSize;
    $scope.itemsPerPage = obj.itemsPerPage;
    $scope.bigCurrentPage = obj.bigCurrentPage;

    var select = function () {
        obj.Skip = ($scope.bigCurrentPage - 1) * $scope.itemsPerPage;
        obj.Take = $scope.itemsPerPage;
        $http.post(obj.getDataUrl, obj).success(function (data) {
            $scope.ResponseData = data;
            $scope.bigTotalItems = data.Total;
            obj.eventFunction();
        });
    }
    select();

    //翻页触发数据读取方法
    $scope.pageChanged = function () {
        select();
    };

    //这里可以扩展直接跳转到N页
    $scope.setPage = function (pageNo) {
        $scope.currentPage = pageNo;
    };

    //改变参数并查询
    $scope.ChangeUrl = function (changeObj) {
        if (changeObj.getDataUrl != null) {
            obj.getDataUrl = changeObj.getDataUrl;
        }
        if (changeObj.eventFunction != null) {
            obj.eventFunction = changeObj.eventFunction;
        }
        select();
    }
}
