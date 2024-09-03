// MyApp.Web/src/app.ts
document.addEventListener('DOMContentLoaded', () => {
    fetch('/api/people')
        .then(response => response.json())
        .then(data => {
            const list = document.getElementById('people-list');
            data.forEach((person: { id: number, name: string }) => {
                const listItem = document.createElement('li');
                listItem.textContent = `${person.id}: ${person.name}`;
                list.appendChild(listItem);
            });
        });
});
