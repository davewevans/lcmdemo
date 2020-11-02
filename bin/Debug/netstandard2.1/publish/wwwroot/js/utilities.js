// test function 
function my_function(message) {
    console.log("from utilities " + message);
    alert("from utilities " + message);
}

function focusInput(id) {
    if (document.getElementById(id) !== null){
        document.getElementById(id).focus();
    }    
}

function showAlert(message) {
    alert(message);
}

function BlazorFocusElement(element) {
    if (element instanceof HTMLElement) {
        element.focus();
    }
}