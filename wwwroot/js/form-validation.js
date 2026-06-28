$(document).ready(function () {

    $("form").on("submit", function (e) {

        let isValid = true;

        $(".error-text").remove();
        $(".is-invalid").removeClass("is-invalid");

        $(this).find("input, select, textarea").each(function () {

            const value = $(this).val();
            const isRequired = $(this).prop("required") || $(this).data("required") === true;

            if (isRequired && (!value || value.trim() === "")) {

                isValid = false;

                $(this).addClass("is-invalid");

                $(this).after(
                    `<small class="text-danger error-text">Campo obrigatório</small>`
                );
            }
        });

        if (!isValid) {
            e.preventDefault();
        }
    });


    $("input, select, textarea").on("input change", function () {

        const value = $(this).val();

        if (value && value.trim() !== "") {
            $(this).removeClass("is-invalid");

            $(this).next(".error-text").remove();
        }
    });

});