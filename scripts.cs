document.getElementById('timerForm').addEventListener('submit', function(event) {
    event.preventDefault();
    const timeInput = document.getElementById('timeInput').value;
    let time = parseInt(timeInput);

    if (time > 60) {
        alert('Please enter a time less than or equal to 60 seconds.');
        return;
    }

    const countdownDisplay = document.getElementById('countdownDisplay');
    countdownDisplay.textContent = time;

    const countdown = setInterval(() => {
        time--;
        countdownDisplay.textContent = time;
        if (time <= 0) {
            clearInterval(countdown);
            alert('Time has come to an end!');
        }
    }, 1000);
});
