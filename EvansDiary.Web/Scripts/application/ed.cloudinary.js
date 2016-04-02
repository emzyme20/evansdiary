(function ($) {
    ed.cloudinary = {
        dynamicImages: function () {
            // Lazy load the images from cloudinary and optimise the format retrieved (get webp if browser supports the format)
            $.cloudinary.config("cloud_name", "dqg9nkccw");
            $(".dynamic_image").webpify();
        }
    }
})(jQuery);