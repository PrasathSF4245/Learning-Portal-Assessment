// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function Delete() {
    var userConfirmed = confirm("Do you want to delete the book?");

    if (userConfirmed) {
        // User clicked "OK" (Yes)
        // Perform the deletion logic here
        alert("Book deleted successfully");
    } else {
        // User clicked "Cancel" (No)
        alert("Deletion canceled");
    }