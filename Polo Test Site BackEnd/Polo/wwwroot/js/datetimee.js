$("#form_daterangepicker_1").daterangepicker();


$("#form_daterangepicker_2").daterangepicker();

$("#form_daterangepicker_3").daterangepicker({
    singleDataPicker:true,
    timePicker:true,
    timePickerSeconds:true,
    timePicker24Hour:true,
    locale:{
        format:"YYYY MM DD  hh:mm:ss"
    }
});


$("#form_daterangepicker_4").daterangepicker({
 autoApply:true,
 startDate:"04/12/2019",
 endDate:"05/12/2019",

});


$("#form_daterangepicker_5").daterangepicker({
    timePicker:true,
    startDate:moment().startOf('hour'),
    endDate:moment().startOf('hour').add(32,'local'),
    locale:{
        format:"M/DD  hh:mm A"
    }
       
   });
   $("#form_daterangepicker_6").daterangepicker({
    autoApply:true,
    startDate:"02/13/2019",
    endDate:"02/13/2019",
   
   });
   