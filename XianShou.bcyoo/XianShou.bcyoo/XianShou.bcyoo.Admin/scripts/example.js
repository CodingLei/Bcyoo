'use strict';
angular.module('ui.bootstrap.demo', ['ui.bootstrap', 'angularFileUpload']);
angular.module('ui.bootstrap.demo').factory('thisService', function () {
    return {
        
        
    };
});
angular.module('ui.bootstrap.demo').controller('PaginationDemoCtrl', function ($scope, $log, $http, thisService) {

    $scope.SharedService = thisService;
        $scope.maxSize = 5; //分页控件显示页码数
        $scope.itemsPerPage = 10; //单页条数
        $scope.bigCurrentPage = 1; //默认页码

        
        function getdate() {
            $http.post('/examples/product', {
                Skip: ($scope.bigCurrentPage - 1) * $scope.itemsPerPage,
                Take: $scope.itemsPerPage,
                OrderByDesc: "AddTime"

            }).success(function (data) {
                $scope.Response = data.Results;
                $scope.bigTotalItems = data.Total;
            });
        }

        getdate();
        //翻页触发数据读取方法
        $scope.pageChanged = function() {
            getdate();
        };

        //这里可以扩展直接跳转到N页
        $scope.setPage = function(pageNo) {
            $scope.currentPage = pageNo;
        };


    }
);
angular.module('ui.bootstrap.demo').controller('PaginationDemoCtrl2', function ($scope, $log, $http, thisService) {
    $scope.SharedService = thisService;
  
    $scope.maxSize = 5; //分页控件显示页码数
    $scope.itemsPerPage = 3; //单页条数
    $scope.bigCurrentPage = 1; //默认页码

    function getdate() {
     
        $http.post('/examples/product', {
            Skip: ($scope.bigCurrentPage - 1) * $scope.itemsPerPage,
            Take: $scope.itemsPerPage,
            OrderByDesc: "AddTime",
            Sku: $scope.SharedService.SearchKey
        }).success(function (data) {
            $scope.Response = data.Results;
            $scope.bigTotalItems = data.Total;
        });
    }

       
       
        $('#myModal').on('shown.bs.modal', function (e) {
            getdate();
        });
 //   getdate();
    //翻页触发数据读取方法
    $scope.pageChanged = function () {
        getdate();
    };

    //这里可以扩展直接跳转到N页
    $scope.setPage = function (pageNo) {
        $scope.currentPage = pageNo;
    };


}
);
angular.module('ui.bootstrap.demo').controller('RatingDemoCtrl', function ($scope) {
    $scope.rate = 7;
    $scope.max = 10;
    $scope.isReadonly = false;

    $scope.hoveringOver = function (value) {
        $scope.overStar = value;
        $scope.percent = 100 * (value / $scope.max);
    };

    $scope.ratingStates = [
      { stateOn: 'glyphicon-ok-sign', stateOff: 'glyphicon-ok-circle' },
      { stateOn: 'glyphicon-star', stateOff: 'glyphicon-star-empty' },
      { stateOn: 'glyphicon-heart', stateOff: 'glyphicon-ban-circle' },
      { stateOn: 'glyphicon-heart' },
      { stateOff: 'glyphicon-off' }
    ];
});




angular.module('ui.bootstrap.demo').controller('CarouselDemoCtrl', function ($scope) {
    $scope.myInterval = 5000;
    var slides = $scope.slides = [];
    $scope.addSlide = function () {
        var newWidth = 600 + slides.length + 1;
        slides.push({
            image: 'http://placekitten.com/' + newWidth + '/300',
            text: ['More', 'Extra', 'Lots of', 'Surplus'][slides.length % 4] + ' ' +
              ['Cats', 'Kittys', 'Felines', 'Cutes'][slides.length % 4]
        });
    };
    for (var i = 0; i < 4; i++) {
        $scope.addSlide();
    }
});

