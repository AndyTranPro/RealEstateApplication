function showConfirmation() {
    document.getElementById("deleteConfirmation").style.display = "block";
}

function closeConfirmation() {
    document.getElementById("deleteConfirmation").style.display = "none";
}

function deleteHome(id) {
    fetch('/HomeDetail?handler=Delete&id=' + id, {
        method: 'POST'
    })
        .then(response => {
            window.location.href = '/Index';
        })
}