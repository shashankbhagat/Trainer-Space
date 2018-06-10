var lMenu = new Vue({
    el: '#lMenu',
    data: {
        appName: 'The app',
        result: 0,
        LocationValue: '1',
        StudioValue: '1',
        galleryTable: '',
        timeValue: 12,
        sliderValue: 7
    },
    methods: {
        fChanged: function () {

            var date = new Date();
            axios({
                method: 'post',
                url: '/Booking/FilterChanged',
                data: {
                    locationSelected: lMenu.LocationValue,
                    studioTypeselected: lMenu.StudioValue,
                    date: date.toISOString()
                    //lMenu.sliderValue
                }
            })
                .then(function (response) {
                    lMenu.galleryTable = response.data;
                    //handle success
                    console.log(response);
                })
                .catch(function (response) {
                    //handle error
                    console.log(response);
                });
        }
    }
});

lMenu.fChanged();