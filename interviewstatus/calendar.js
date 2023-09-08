$(document).ready(function () {
    var currentDate = new Date();
    var monthsToShow = 3;

    for (var i = 0; i < monthsToShow; i++) {
        var calendarMonth = new Date(currentDate);
        calendarMonth.setMonth(currentDate.getMonth() + i);

        generateCalendar(calendarMonth);
    }
});

function generateCalendar(date) {
    var year = date.getFullYear();
    var month = date.getMonth();
    var daysInMonth = new Date(year, month + 1, 0).getDate();

    var $calendarContainer = $('#calendarContainer');
    var $calendar = $('<div class="calendar"></div>');

    // Create the header for the calendar
    $calendar.append('<h2>' + date.toLocaleString('default', { month: 'long', year: 'numeric' }) + '</h2>');

    // Generate the days of the month
    for (var day = 1; day <= daysInMonth; day++) {
        var $day = $('<div class="day">' + day + '</div>');
        $calendar.append($day);
    }

    $calendarContainer.append($calendar);
}
