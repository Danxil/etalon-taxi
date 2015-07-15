app.directive('scrollTo', function() {
    return {
        link: function($scope, elem, attrs) {
            $scope.$watch(attrs.scrollTo, function(newVal) {
                if (newVal)
                    $('html, body').animate({
                        scrollTop: elem.offset().top - 200
                    }, 2000);
            })
        }
    };
});