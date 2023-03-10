$(document).ready(() => {

    $(".addtobasket").click(function (e) {
        e.preventDefault();

        let url = $(this).attr("href");

        fetch(url)
            .then(res => {
                return res.text();
            })
            .then(data =>
            {
                $(".header-cart").html(data);
            })
    })


    $(".productModalBtn").click(function (e) {
        e.preventDefault();

        let url = $(this).attr("href");

        fetch(url)
            .then(res => {
                return res.text();
            })
            .then(data =>
            {
                $(".modal .modal-dialog .modal-content .modal-body").html(data);
                $(".modal").show();
                $('.quick-view-image').slick({
                    slidesToShow: 1,
                    slidesToScroll: 1,
                    arrows: false,
                    dots: false,
                    fade: true,
                    asNavFor: '.quick-view-thumb',
                    speed: 400,
                });

                $('.quick-view-thumb').slick({
                    slidesToShow: 4,
                    slidesToScroll: 1,
                    asNavFor: '.quick-view-image',
                    dots: false,
                    arrows: false,
                    focusOnSelect: true,
                    speed: 400,
                });
            })
    })

    $(".searchBtn").click(() => {
        let searchInput = $(".searchInput").val();
        let searchCategory = $(".searchCategory option:selected").val();


        if (searchInput.length >= 0) {
            fetch('/shop/search/' + searchCategory + '?search=' + searchInput)
                .then(response => {
                    return response.text();
                })
                .then(data => {
                    $("#searchList").html(data);
                })

            //Old Partial 
            //fetch('/shop/search/' + searchCategory + '?search=' + searchInput)
            //    .then(response => {
            //        return response.json();
            //    }).then(data => {
            //        //console.log(data);

            //        let liItems = '';

            //        for (var i = 0; i < data.length; i++) {
            //            let liItem = `<li>
            //                                <img width="100" src="/assets/images/product/${data[i].image}" alt="Alternate Text" />
            //                                <a href="#">${data[i].title}</a>
            //                            </li>`

            //            liItems += liItem;
            //        }

            //        //console.log(liItems);

            //        $("#searchList").html(liItems);
            //    })
        }

    })

    $(".searchInput").keyup(function () {
        let inputVal = $(this).val();

        if (inputVal.length <= 0) {
            $("#searchList").html('');
        }
    })

    //$(document).on("click", function (e) {
    //    let name = e.target.;
    //    if (name != "searchInput") {
    //        $("#searchList").html('');
    //    }
    //})
})