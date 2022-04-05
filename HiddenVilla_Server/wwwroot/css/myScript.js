window.ShowToaster = (type, message) => {
    if (type === "success") {
        window.toastr.success("This is Success", "Operation Result");
        
    }
    if (type === "error") {
        toastr.success("This is Error", "Operation Result");
    }

}