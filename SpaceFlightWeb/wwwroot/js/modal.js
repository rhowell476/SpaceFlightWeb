const openAPODModal = document.getElementById('obAM');
const closeAPODModal = document.getElementById('cbAM');
const APODModal = document.getElementById('APODModal');
const openRANDModal = document.getElementById('obARM');
const closeRANDModal = document.getElementById('cbARM');
const randAPODModal = document.getElementById('randAPODmodal');

function openCheck(dialog) {
    if (dialog.open) {
        console.log('Dialog open');
    } else {
        console.log('Dialog closed');
    }
}

openAPODModal.addEventListener("click", function() {
    APODModal.showModal();
});

closeAPODModal.addEventListener("click", function () {
    APODModal.close();
});

openRANDModal.addEventListener("click", function () {
    randAPODModal.showModal();
});

closeRANDModal.addEventListener("click", function () {
    randAPODModal.close();
});


