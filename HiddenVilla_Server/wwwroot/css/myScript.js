window.ShowToaster = (type, message) => {
    if (type === "success") {
        window.toastr.success("This is Success", "Operation Result");
        
    }
    if (type === "error") {
        toastr.error("This is Error", "Operation Result");
    }
    if (type === "warning") {
        toastr.warning("This is warning", "Operation Result");
    }
    if (type === "info") {
        toastr.info("This is info", "Operation Result");
    }

}
window.ShowSweetAlert = (type, message) => {

    Swal.fire(
        'Good job!',
        'You clicked the button!',
        'success'
    );
}