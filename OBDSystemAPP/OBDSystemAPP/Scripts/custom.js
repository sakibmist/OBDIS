 
$(document).ready(function() {

    $("#divisionDropDownList").change(function (e) {
        e.preventDefault();
        var value = $(this).val();
        if (value !== "") {
            $.ajax({            //req send to server from client via ajax.
                type: "post",
                url: "../Services/AjaxHandlerServerWork.asmx/GetAllDistricts",
                data: JSON.stringify({ divisionId: value }),
                dataType: "json",
                contentType: "application/json; charset=utf-8",
                             //response from server.
                success: function (response) { //server all json data provide kore.
                    var object = JSON.parse(response.d);//json data ke javascript er object e convert kora holo.
                     $("#districtDropDownList").html('<option value="">Select One </option>'); 
                    $.each(object, function (key, value) { 
                        $("#districtDropDownList").append('<option value="' + value.Id + '">' + value.DistrictName + '</option>');
                    }); 
                }

            });
        }
    });

    $("#districtDropDownList").change(function (e) {
        e.preventDefault();
        var value = $(this).val();
        if (value!=="") {
            $.ajax({
                type: "post", 
                url: "../Services/AjaxHandlerServerWork.asmx/GetAllSubDistricts",
                data: JSON.stringify({ districtId: value }),
                dataType: "json",
                contentType: "application/json; charset=utf-8",
                success: function(res) {
                    var obj = JSON.parse(res.d);
                    $("#subDistrictDropDownList").html('<option value="">Select One</option>'); 
                    $.each(obj, function (key, value) { 
                        $("#subDistrictDropDownList").append('<option value="'+value.Id+'">'+value .SubDistrictName+'</option>');
                    });
                }
            });
        }
    });

   /* $("#districtName").keyup(function () {
        var districtName = $(this).val();
        if (value !== "") {
            $.ajax({
                type: "post",
                url: "../Services/AjaxHandlerServerWork.asmx/DistrictNameExist",
                data: JSON.stringify({ districtId: districtName }),
                dataType: "json",
                contentType: "application/json; charset=utf-8",
                success: function (res) {
                    console.log(res.d);
                }
            });
        }
    });
  */
   

});