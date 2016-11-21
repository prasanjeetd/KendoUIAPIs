var layout = new kendo.Layout("<header>Header</header><section id='content'></section><footer>Footer</footer>");

var model = {
    model: viewModel,
    init: viewModel.init.bind(viewModel),
    show: viewModel.show.bind(viewModel)
};
var indexview = new kendo.View("index", model);

var detailview = new kendo.View("detail");

var view3Model = kendo.observable({
    param1: "Pussy",
    param2: "Cat"
});
var view3model = {
    model: view3Model
};

var view3 = new kendo.View("view3", view3model);

//router
var router = new kendo.Router();

router.bind("init", function () {
    layout.render($("#app"));
});

router.route("/", function () {
    layout.showIn("#content", indexview);
});

router.route("/detail", function () {
    layout.showIn("#content", detailview);
});

router.route("/optional(/:param1)(/:param2)", function (param1, param2) {
    console.log("parameter1:", param1, "parameter2:", param2);

    view3Model.param1 = param1;
    view3Model.param2 = param2;
    layout.showIn("#content", view3);
});

window.router = router;