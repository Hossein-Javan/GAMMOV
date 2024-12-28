$(document).ready(function () {
    $('#iconPicker').iconpicker({
        align: 'center',
        arrowClass: 'btn-primary',
        arrowPrevIconClass: 'bi bi-chevron-left',
        arrowNextIconClass: 'bi bi-chevron-right',
        cols: 10,
        icon: 'bi-alarm',
        iconset: 'bi',
        labelHeader: '{0} از {1} صفحات',
        labelFooter: '{0} - {1} از {2} آیکون‌ها',
        placement: 'bottom',
        rows: 5,
        search: true,
        searchText: 'جستجو',
        selectedClass: 'btn-success',
        unselectedClass: ''
    }).on('change', function (e) {
        // تنظیم مقدار آیکون انتخاب شده به فیلد ورودی
        $('#iconInput').val($(e.iconpickerInstance).iconpicker('getIcon'));
    });
});
