ShowToastr = (command) => {
    if (command === "success") {
        toastr.success('Operation Successful', 'Success!', { timeOut: 5000 });
    }
    else if (command === "error") {
        toastr.error('Operation Successfully Failed!', 'Error!', { timeOut: 5000 });
    }
}