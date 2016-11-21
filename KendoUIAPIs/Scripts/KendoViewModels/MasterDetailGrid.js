var MasterDetailGridVM = function () {

    var applicantModel = kendo.data.Model.define({
        id: "ApplicantRoundID",
        fields: {
            ApplicantRoundID: { type: "number" },
            ApplicantID: { type: "number" },
            FirstName: { type: "string" },
            MiddleName: { type: "string" },
            LastName: { type: "string" },
            Experience: { type: "number" },
            PostID: { type: "number" },
            PostName: { type: "string" },
            RoundID: { type: "number" },
            RoundName: { type: "string" }
        }
    });

    var applicantListModel = kendo.observable({

        rounds: new kendo.data.DataSource({
            schema: {
                model: {
                    id: "RoundID",
                    fields: {
                        RoundID: {
                            editable: false,
                            nullable: true
                        },
                        RoundName: {
                            editable: true,
                            nullable: true
                        }
                    }
                }
            },
            batch: true,
            transport: {
                read: {
                    url: "api/Applicants/GetRounds",
                },
            },

        }),

        applicantListDS: new kendo.data.DataSource({
            schema: {
                model: applicantModel
            },
            transport: {
                read: {
                    url: "api/Applicants/GetApplicantList",
                    //dataType: "json"
                },
            },
        }),

        gridDetailInit: function (e) {

            var detailRow = e.detailRow;
            var detailCell = jQuery(detailRow).find(".k-detail-cell");
            //console.log(detailCell);

            var grid = $("#applicantGrid").data("kendoGrid");
            var parentDataItem = grid.dataItem(e.masterRow);
            var roundId = parentDataItem.RoundID;

            var applicantListDS = applicantListModel.get("applicantListDS");
            var detailDataSource = new kendo.data.DataSource({
                schema: {
                    model: applicantModel
                },
                filter: { field: "RoundID", operator: "eq", value: roundId },
                data: applicantListDS.data()
            });


            $("<div id='newDetailGrid' class='detailGridClass'/>").appendTo(detailCell).kendoGrid({
                dataSource: detailDataSource,

                columns: [
                    { field: "FirstName", title: "Name" },
                    { field: "Experience", title: "Experience" },
                    { field: "PostName", title: "Post" },
                    { field: "RoundName", title: "Round" },
                    {
                        command:
                          [
                            "edit",
                            {
                                name: "deleteBatch",
                                text: "Delete",
                                click: function (e) {
                                    e.preventDefault();
                                }
                            }
                          ]
                    }
                ],
                editable: "popup",
                edit: function (e) {
                    //debugger;
                    //console.log(e);
                    //var masterRow = this.wrapper.closest("tr.k-detail-row").prev(".k-master-row");
                    //masterGrid = jQuery("#sampleGrid").data("kendoGrid");
                    //var masterDataItem = masterGrid.dataItem(masterRow);
                    //var maxData = detailData[detailData.length - 1];
                    //e.model.set("BatchId", maxData.BatchId + 1);
                    //e.model.set("ProductID", masterDataItem.ProductID);
                },
                save: function (e) {
                    //debugger;
                    //console.log(e);
                    //$(detailCell).show();
                }
            });

            //$(".detailGridClass .k-toolbar.k-grid-toolbar").css("display", "none");
            //if (detailDataSource.view().length <= 0) {
            //	$(detailCell).hide();
            //}

            detailDataSource.read();
        },

        databound: function (e) {
            console.log(e);
            applicantListModel.expandAllDetails();
        },
        //addNewBatch: function (e) {

        //    var button = $(e.currentTarget).closest('tr').next().find(".k-grid-add");
        //    $(button).click();
        //},
        expandAllDetails: function () {
            var masterGrid = $("#applicantGrid").data("kendoGrid");
            var rows = masterGrid.tbody.find("tr.k-master-row");
            //console.log("Rows");
            //console.log(rows);
            masterGrid.expandRow(rows);
        },

        loadView: function () {
            applicantView.render("#applicantlist");
            var applicantListDS = applicantListModel.get("applicantListDS");
            applicantListDS.read();
        }

    });

    var applicantView = new kendo.View('applicantlist-template');
    applicantView.model = applicantListModel;

    var router = new kendo.Router({
        init: function () {
            console.log("Init called");
            applicantListModel.loadView();
        }
    });


    router.start();

    kendo.bind($("#applicantGrid"), applicantListModel);

}