document.querySelectorAll('.buy-button').forEach(button => {
button.addEventListener('click', (e) => {
const smoke = document.createElement('div');
smoke.classList.add('smoke-effect');
button.appendChild(smoke);

setTimeout(() => smoke.remove(), 1000); // Remove smoke after animation
});
});