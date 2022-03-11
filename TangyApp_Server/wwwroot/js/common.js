﻿ShowToastr = (command) => {
    if (command === "success") {
        toastr.success('Operation Successful', 'Success!', { timeOut: 5000 });
    }
    else if (command === "error") {
        toastr.error('Operation Successfully Failed!', 'Error!', { timeOut: 5000 });
    }
};

ShowSwal = (obj) => {
    if (obj.icon == "success") {
        Swal.fire({
            icon: "success",
            title: "Operation Successful!"
        });
    }

    else if (obj.icon == "error") {
        Swal.fire({
            icon: "error",
            title: "Operation Successfully Failed!"
        });
    }     
}