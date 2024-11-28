let map;
let marker;

var icons = {
    0:
        L.icon({
            iconUrl: '../icon/MarcadorPosicao.png',
            iconSize: [30, 35],
            iconAnchor: [12, 41],
            popupAnchor: [1, -34],
            shadowSize: [41, 41]
        }),
    1:
        L.icon({
            iconUrl: '../icon/marcador1.png',
            iconSize: [30, 35],
            iconAnchor: [12, 41],
            popupAnchor: [1, -34],
            shadowSize: [41, 41]
        }),
    2:
        L.icon({
            iconUrl: '../icon/marcador2.png',
            iconSize: [30, 35],
            iconAnchor: [12, 41],
            popupAnchor: [1, -34],
            shadowSize: [41, 41]
        }),
    3:
        L.icon({
            iconUrl: '../icon/marcador3.png',
            iconSize: [30, 35],
            iconAnchor: [12, 41],
            popupAnchor: [1, -34],
            shadowSize: [41, 41]
        }),
    4:
        L.icon({
            iconUrl: '../icon/marcador4.png',
            iconSize: [30, 35],
            iconAnchor: [12, 41],
            popupAnchor: [1, -34],
            shadowSize: [41, 41]
        }),
    5:
        L.icon({
            iconUrl: '../icon/marcador5.png',
            iconSize: [30, 35],
            iconAnchor: [12, 41],
            popupAnchor: [1, -34],
            shadowSize: [41, 41]
        }),
    6:
        L.icon({
            iconUrl: '../icon/marcador6.png',
            iconSize: [30, 35],
            iconAnchor: [12, 41],
            popupAnchor: [1, -34],
            shadowSize: [41, 41]
        }),
    7:
        L.icon({
            iconUrl: '../icon/marcador7.png',
            iconSize: [30, 35],
            iconAnchor: [12, 41],
            popupAnchor: [1, -34],
            shadowSize: [41, 41]
        }),
    8:
        L.icon({
            iconUrl: '../icon/marcador8.png',
            iconSize: [30, 35],
            iconAnchor: [12, 41],
            popupAnchor: [1, -34],
            shadowSize: [41, 41]
        })
}

function createMap() {
    map = L.map('map').setView([0, 0], 2);

    L.tileLayer(
        'https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png',
        {
            attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
        }
    ).addTo(map);
}

function setPosition() {
    map.on("click", function (event) {
        let lat = event.latlng.lat;
        let lng = event.latlng.lng;

        let position = [lat, lng];

        if (marker) {
            map.removeLayer(marker);
        }

        marker = L.marker(position).addTo(map).bindPopup("Você selecionou aqui!").openPopup();
        document.querySelector("#lat").value = lat;
        document.querySelector("#lng").value = lng;

    });
}

function setStartingPosition(lat, lng) {

    let position = [lat, lng];
    map.setView(position, 16);

    if (marker) {
        map.removeLayer(marker)
    }

    marker = L.marker(position).addTo(map).bindPopup('Você está aqui!').openPopup();
}

function getStartingPosition() {

    let latDefault = -23.55052;
    let lngDefault = -46.633308;

    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(
            function (geolocationPosition) {
                let lat = geolocationPosition.coords.latitude;
                let lng = geolocationPosition.coords.longitude;
                setStartingPosition(lat, lng);
            },
            function (error) {
                console.error(`Erro ao obter a geolocalização: ${error.message}`);
                setStartingPosition(latDefault, lngDefault);
            }
        );
    }
    else {
        console.error(`Geolocalização não é suportada pelo seu navegador`);
        setStartingPosition(latDefault, lngDefault);
    }
}

function addIncidents(incidents) {
    incidents.forEach((incident) => {

        let latitude = Number(incident.location.latitude).toFixed(6);
        let longitude = Number(incident.location.longitude).toFixed(6);
        let position = [latitude, longitude];

        L.marker(position, { icon: icons[incident.categoryId] })
            .addTo(map)
            .bindPopup('Informações: <br> Categoria: ' + incident.category.name + '<br> Descrição: ' + incident.description)
            .openPopup();

    });
}
