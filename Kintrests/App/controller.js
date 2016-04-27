(function () {
    'use strict';

    angular
        .module('Kintrestapp')
        .controller('Kincontroller', controller);

    controller.$inject = ['$scope']; 

    function controller($scope) {
        activate();
    


        function activate() {
            //factory.getData

            var kins = [
                {
                    Id: 8,
                    Body: "I love the turrets in Portal 2",
                    ImgURL: "https://img.society6.com/cdn/0014/p/4531933_12374889_lz.jpg",
                    LinkURL: "https://img.society6.com/cdn/0014/p/4531933_12374889_lz.jpg",
                    OwnerHandle: "kateramsey"
                },
                {
                    Id: 9,
                    Body: "Oh Wheatley :)",
                    ImgURL: "https://s-media-cache-ak0.pinimg.com/564x/b2/dc/20/b2dc20d029a41b8e3aa0e69e18f12e57.jpg",
                    LinkURL: "http://www.thinkwithportals.com/",
                    OwnerHandle: "kateramsey"
                },
                {
                    Id: 10,
                    Body: "Life Lessons from Cave Johnson",
                    ImgURL: "https://s-media-cache-ak0.pinimg.com/564x/e6/e4/24/e6e424039a44edc9f4270bc909d1a3aa.jpg",
                    LinkURL: "https://www.etsy.com/listing/73754501/when-life-gives-you-lemons-11x17-poster",
                    OwnerHandle: "kateramsey"
                },
                {
                    Id: 11,
                    Body: "From the sky to the core",
                    ImgURL: "https://s-media-cache-ak0.pinimg.com/564x/5d/17/fd/5d17fd0bd22c8bc20d7e0c32ce91677a.jpg",
                    LinkURL: "http://decarabia.soup.io/post/138052126/Image",
                    OwnerHandle: "kateramsey"
                },
                {
                    Id: 12,
                    Body: null,
                    ImgURL: "https://s-media-cache-ak0.pinimg.com/564x/a9/75/2b/a9752b80f4dfec1668117a8c9dba0597.jpg",
                    LinkURL: "https://s-media-cache-ak0.pinimg.com/564x/a9/75/2b/a9752b80f4dfec1668117a8c9dba0597.jpg",
                    OwnerHandle: "kateramsey"
                },
                {
                    Id: 13,
                    Body: null,
                    ImgURL: "https://s-media-cache-ak0.pinimg.com/originals/87/b0/85/87b085cf7b1cc5f460cba801f6226d54.jpg",
                    LinkURL: "https://s-media-cache-ak0.pinimg.com/originals/87/b0/85/87b085cf7b1cc5f460cba801f6226d54.jpg",
                    OwnerHandle: "kateramsey"
                }
            ];
        }
    }
})();
