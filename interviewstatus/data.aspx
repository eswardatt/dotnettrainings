<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="data.aspx.cs" Inherits="interviewstatus.data" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link rel="stylesheet" href="https://code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" />
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>

    <style>
        .present {
            background-color: green;
            color: white;
        }

        .absent {
            background-color: blue;
            color: white;
        }

        .hold {
            background-color: gray;
            color: white;
        }

        .custom-success {
            color: #1AAE9F;
            background-color: #E6F7F6;
            border-color: #1AAE9F;
        }
      
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">

            <br />
            <br />
            <br />
            <div id="result"></div>
            <h2>Calendar</h2>
            <div id="calendar-container"></div>
            
            <div class="row" style="display: none;">
                <div class="col">
                    <asp:Calendar ID="myCalendar" runat="server" Columns="2" Rows="2" OnDayRender="myCalendar_DayRender"></asp:Calendar>
                </div>
            </div>
        </div>
    </form>
    <script>

        function getData() {

        }
        $(document).ready(function () {
            
            var jsonData = [
                { Id: 1, JobDate: '2023-08-24T00:00:00', JobDescription: null, JobStatus: 'hold', Name: 'Ram' },
                { Id: 2, JobDate: '2023-08-26T00:00:00', JobDescription: null, JobStatus: 'Present', Name: 'Ram' },
                { Id: 3, JobDate: '2023-08-23T00:00:00', JobDescription: null, JobStatus: 'absent', Name: 'Ram' }
            ];
            // Initialize the datepicker
            $("#calendar-container").datepicker({
                numberOfMonths: 3,
                showButtonPanel: true,
                beforeShowDay: function (date) {
                    //var Jobdata = getData();
                    //console.log("jsonData", Jobdata);
                    for (var i = 0; i < jsonData.length; i++) {
                        var customDate = new Date(jsonData[i].JobDate);
                        if (date.toDateString() === customDate.toDateString()) {
                            if (jsonData[i].JobStatus == 'Present') {
                                return [true, 'present', 'Present'];
                            }
                            else if (jsonData[i].JobStatus == 'absent') {
                                return [true, 'absent', 'absent'];
                            }
                            else if (jsonData[i].JobStatus == 'hold') {
                                return [true, 'hold', 'hold'];
                            }
                        }
                    }
                    return [true, ""];
                }
            });
        });

    </script>
</body>
</html>
