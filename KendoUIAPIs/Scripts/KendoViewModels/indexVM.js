var viewModel = kendo.observable({

    foo: "World !",

    init: function () {
        console.log("view init", this.foo);
    },

    show: function () {
        console.log("view show", this.foo);
    },

    goToView2: function (e) {
        window.router.navigate("/detail");
        e.preventDefault();
    }

});