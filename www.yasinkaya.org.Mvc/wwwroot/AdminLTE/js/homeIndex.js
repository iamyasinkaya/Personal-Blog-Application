$(document).ready(function () {
    //Datatable
    $('#articlesTable').DataTable({
        "order": [[4, "desc"]],
        language: {
            "sDecimal": ",",
            "sEmptyTable": "Tabloda herhangi bir veri mevcut değil",
            "sInfo": "_TOTAL_ kayıttan _START_ - _END_ arasındaki kayıtlar gösteriliyor",
            "sInfoEmpty": "Kayıt yok",
            "sInfoFiltered": "(_MAX_ kayıt içerisinden bulunan)",
            "sInfoPostFix": "",
            "sInfoThousands": ".",
            "sLengthMenu": "Sayfada _MENU_ kayıt göster",
            "sLoadingRecords": "Yükleniyor...",
            "sProcessing": "İşleniyor...",
            "sSearch": "Ara:",
            "sZeroRecords": "Eşleşen kayıt bulunamadı",
            "oPaginate": {
                "sFirst": "İlk",
                "sLast": "Son",
                "sNext": "Sonraki",
                "sPrevious": "Önceki"
            },
            "oAria": {
                "sSortAscending": ": artan sütun sıralamasını aktifleştir",
                "sSortDescending": ": azalan sütun sıralamasını aktifleştir"
            },
            "select": {
                "rows": {
                    "_": "%d kayıt seçildi",
                    "0": "",
                    "1": "1 kayıt seçildi"
                }
            }
        },

    });

    //Datatable
    //Chart Js

    const categories = [
        {

            name: 'C#',
            viewCount: '24500'

        }, {

            name: 'C++',
            viewCount: '77000'

        }, {

            name: 'Javascript',
            viewCount: '57880'

        }, {

            name: 'Dart',
            viewCount: '5750'

        }, {

            name: 'Php',
            viewCount: '117453'

        }]

    let viewCountContext = $('#viewCountChart');

    let viewCountChart = new Chart(viewCountContext,
        {

            type: 'bar',
            data: {
                labels: categories.map(category => category.name),
                datasets: [
                    {
                        label: 'Okunma Sayısı',
                        data: categories.map(category => category.viewCount),
                        backgroundColor: ['#FCF8E8', '#D4E2D4', '#ECB390', '#DF7861', '#F38BA0'],
                        hoverBorderWidth: 4,
                        hoverBorderColor: 'black'
                    }]
            },
            options: {
                plugins: {
                    legend: {
                        labels: {
                            font: {
                                size: 15
                            }
                        }
                    }
                }
            }

        });
});