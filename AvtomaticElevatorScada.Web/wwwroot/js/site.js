function updateEmergencySensor(sensor, value) {
    sensor.classList.remove("emergency-normal", "emergency-active");

    if (Number(value) === 1) {
        sensor.classList.add("emergency-active");
    } else {
        sensor.classList.add("emergency-normal");
    }
}

function showReading(r) {
    document.querySelectorAll(
        `.sensor[data-topic="${r.topic}"]`
    ).forEach(el => {
        el.querySelector('.value').textContent =
            `${r.value} ${r.unit}`;

        if (
            r.topic.includes('/emergency/fire') ||
            r.topic.includes('/emergency/motor_overheat') ||
            r.topic.includes('/emergency/stop')
        ) {
            updateEmergencySensor(el, r.value);
        }
    });
}

async function refresh() {
    try {
        const res = await fetch('/Scheme/Current');

        if (!res.ok) {
            throw new Error(`HTTP ${res.status}`);
        }

        const list = await res.json();

        console.log('Полученные данные:', list);

        list.forEach(showReading);
    } catch (e) {
        console.error('Помилка оновлення', e);
    }
}

refresh();
setInterval(refresh, 2000);