const categoriesData = {
    coffeepoints: [
        {
            lat: 52.09564808831621,
            lon: 23.756754666619592,
            name: 'Кофейня 21',
            icon: 'https://cdn-icons-png.flaticon.com/128/3081/3081183.png',
            description: '<p>Местонахождение:</p><p>возле лестницы на 1-ом этаже 2-го корпуса</p>',
            work_time: '<p>Время работы: Пн-Пт 9:00-18:00</p>',
            photo: '<img src="https://thumb.tildacdn.com/tild6237-6362-4939-b031-616364343235/-/resize/478x/-/format/webp/photo_2023-03-11_13-.png" width="200" height="250">',
            hint: 'Кофепоинт'
        },
        {
            lat: 52.09654087426673,
            lon: 23.758370426678145,
            name: 'Кофейный автомат',
            icon: 'https://cdn-icons-png.flaticon.com/128/3081/3081183.png',
            description: '',
            work_time: '',
            photo: '',
            hint: 'Кофепоинт'
        },
    ],
    canteens: [
        {
            lat: 52.094226839478,
            lon: 23.76053080416939,
            name: 'Столовая "Зодчие"',
            icon: 'https://cdn-icons-png.flaticon.com/128/2060/2060777.png',
            description: '',
            work_time: '',
            photo: '',
            hint: 'Столовая'
        },
    ],
    buffets: [
        {
            lat: 52.09564364240153,
            lon: 23.756744938574816,
            name: 'Буфет 2-й Корпус',
            icon: 'https://cdn-icons-png.flaticon.com/128/5589/5589708.png',
            description: '<p>Местонахождение:</p><p>возле гардероба на 1-ом этаже 2-го корпуса</p>',
            work_time: '',
            photo: '',
            hint: 'Буфет'
        },
    ],
    printing_points: [
        {
            lat: 52.09655184182871,
            lon: 23.757886672563842,
            name: 'Пункт печати',
            icon: 'https://cdn-icons-png.flaticon.com/128/3233/3233468.png',
            description: '<p>Местонахождение: библиотека 1-го корпуса</p>',
            work_time: '',
            photo: '',
            hint: 'Пункт печати'
        },
    ],
    deans: [
        {
            lat: 52.09627699661334,
            lon: 23.756373913044893,
            name: 'Деканат ФЭИС',
            icon: 'https://cdn-icons-png.flaticon.com/128/5352/5352126.png',
            description: '',
            work_time: '',
            photo: '',
            hint: 'Деканат'
        },
    ]
};

const polygonData = [
    {
        polygonCoordinates: [
            [52.096445985756695,23.758217054913647],
            [52.09645716142553,23.75826332927346],
            [52.09646916354183,23.758265752736946],
            [52.09653898430223,23.758229284169804],
            [52.09649030221477,23.757990050076526],
            [52.09663743336128,23.757912304032644],
            [52.09689589564927,23.759204053692194],
            [52.09698466975905,23.75916016375939],
            [52.09703133714326,23.759388822077657],
            [52.09679562695191,23.75951341885888],
            [52.09657656161087,23.758419724625067],
            [52.09650848639507,23.75845574722412],
            [52.09649492585156,23.75845421889701],
            [52.09602023006038,23.75870337882364],
            [52.09597326320054,23.75846658494453],
            [52.096445985756695,23.758217054913647]],
        name: '1-й корпус',
        textCoordinates: [52.09671512364851,23.758689136066575],
        fillColor: '#e8e53355',
        strokeColor: '#c4c22b',
        offset: [0,0],
        markerTemplate: 'islands#yellowStretchyIcon'
    },
    {
        polygonCoordinates: [
            [52.09571818127079,23.756590160266573],
            [52.09572520223125,23.756619664565743],
            [52.09633789699138,23.75628820157297],
            [52.096384152064665,23.756518200995988],
            [52.09563062567057,23.756922083632116],
            [52.09572968067452,23.757406096630692],
            [52.095804781643245,23.757366408319218],
            [52.0958211724548,23.75744528202805],
            [52.09556237761262,23.75758425398267],
            [52.09539913939574,23.756785290972392],
            [52.09553362253693,23.75671052439608],
            [52.09555659562392,23.756711530224464],
            [52.09566696952561,23.756652521626176],
            [52.095661187550625,23.756623017327005],
            [52.09571818127079,23.756590160266573]
        ],
        name: '2-й корпус',
        textCoordinates: [52.095894585176985,23.756666998816936],
        fillColor: '#3498db55',
        strokeColor: '#2980b9',
        offset: [0,0],
        markerTemplate: 'islands#blueStretchyIcon'
    },
    {
        polygonCoordinates: [
            [52.09539859034486,23.756790477898342],
            [52.095463844404485,23.757109660771118],
            [52.09462021486835,23.757568004520536],
            [52.09455454655992,23.75724882164776],
            [52.09539859034486,23.756790477898342]
        ],
        name: '3-й корпус',
        textCoordinates: [52.09505786347536,23.757160308750276],
        fillColor: '#db343455',
        strokeColor: '#db3434',
        offset: [0,0],
        markerTemplate: 'islands#redStretchyIcon'
    },
    {
        polygonCoordinates: [
            [52.0958065592465,23.759146959789224],
            [52.09579633757247,23.7591519051121],
            [52.09576546603741,23.758994576789586],
            [52.09577496497349,23.758990218199916],
            [52.095722514300824,23.7587266911642],
            [52.09571260235583,23.758733396686743],
            [52.09569773443399,23.758653265692306],
            [52.09560811379959,23.75869919852182],
            [52.09562463374582,23.758778323687746],
            [52.095564748911684,23.75881118074818],
            [52.095577345383525,23.75886650130912],
            [52.09557249264482,23.758867339499425],
            [52.09561219216199,23.759072947584176],
            [52.09562950664495,23.75906632999819],
            [52.09565921107051,23.759221315505346],
            [52.09564551920821,23.75922953800551],
            [52.095688758181915,23.759453183652223],
            [52.09569263649092,23.75945388714461],
            [52.09570369709073,23.759508938309672],
            [52.0957745519764,23.759474201353008],
            [52.09581796828391,23.759690382699855],
            [52.09589525023903,23.759649784385353],
            [52.09584992389817,23.759419766277748],
            [52.095860042310804,23.759416018881048],
            [52.0958065592465,23.759146959789224]
        ],
        name: '5-й корпус',
        textCoordinates: [52.0957112144053,23.759098457954728],
        fillColor: '#34db6055',
        strokeColor: '#34db60',
        offset: [0,0],
        markerTemplate: 'islands#darkGreenStretchyIcon'
    },
    {
        polygonCoordinates: [
            [52.095869978863966,23.75766735499047],
            [52.09597157583621,23.758174292494296],
            [52.09581752830356,23.75825542931694],
            [52.095731582689915,23.757839921856476],
            [52.0957410816333,23.75783455743845],
            [52.09572290973989,23.75774470343639],
            [52.095869978863966,23.75766735499047]
        ],
        name: 'Галерея',
        textCoordinates: [52.095840613917844,23.757952574635055],
        fillColor: '#c534db55',
        strokeColor: '#c534db',
        offset: [0,0],
        markerTemplate: 'islands#pinkStretchyIcon'
    },
    {
        polygonCoordinates: [
            [52.096532007389754,23.75738827545522],
            [52.09663525480333,23.757903930138536],
            [52.09646881985409,23.757991772484054],
            [52.09636639803663,23.757476788352808],
            [52.096532007389754,23.75738827545522]
        ],
        name: 'Актовый зал',
        textCoordinates: [52.09649946952253,23.757697050164982],
        fillColor: '#1518d355',
        strokeColor: '#1518d3',
        offset: [0,0],
        markerTemplate: 'islands#darkBlueStretchyIcon'
    },
    {
        polygonCoordinates: [
            [52.09610769232424,23.759582560666956],
            [52.09665955299924,23.759292196079105],
            [52.096705394748746,23.759521524949925],
            [52.0958390785136,23.759975574410262],
            [52.09578621491956,23.75970936516553],
            [52.09589477329895,23.75965204173709],
            [52.09609963893884,23.759543026648032],
            [52.09610769232424,23.759582560666956]
        ],
        name: 'Спортивный комплекс',
        textCoordinates: [52.09616862568659,23.759671329976513],
        fillColor: '#d3811555',
        strokeColor: '#d38115',
        offset: [0,0],
        markerTemplate: 'islands#orangeStretchyIcon'
    },
    {
        polygonCoordinates: [
            [52.09500663461377,23.760659503601403],
            [52.09504628301156,23.760874080322587],
            [52.0943703830019,23.761214509559274],
            [52.09433073400037,23.761003956151598],
            [52.09500663461377,23.760659503601403]
        ],
        name: 'Общежитие №1',
        textCoordinates: [52.094688361687844,23.760931567409827],
        fillColor: '#8234db55',
        strokeColor: '#8234db',
        offset: [0,0],
        markerTemplate: 'islands#violetStretchyIcon'
    },
    {
        polygonCoordinates: [
            [52.09444945841464,23.761728020516294],
            [52.09446298447413,23.761799392638316],
            [52.09515594762058,23.761464451836048],
            [52.09519518288252,23.76167701690054],
            [52.09449521988712,23.76201582252813],
            [52.09448483268635,23.76196140619588],
            [52.093867985901255,23.762258308372328],
            [52.09382606486641,23.762029691400866],
            [52.09444945841464,23.761728020516294]
        ],
        name: 'Общежитие №2',
        textCoordinates: [52.09451063644836,23.761881830207802],
        fillColor: '#8234db55',
        strokeColor: '#8234db',
        offset: [0,0],
        markerTemplate: 'islands#violetStretchyIcon'
    },
    {
        polygonCoordinates: [
            [52.09461042133827,23.759805800429397],
            [52.094639331889944,23.759958686343175],
            [52.09484723746681,23.759856762400673],
            [52.094882342947194,23.76004719924046],
            [52.094623224584986,23.760174604168572],
            [52.094599802831844,23.760042277601038],
            [52.094392591978284,23.760143303217827],
            [52.09435314950144,23.759933101933253],
            [52.09461042133827,23.759805800429397]
        ],
        name: 'Общежитие №3',
        textCoordinates: [52.09460185949256,23.75994894968477],
        fillColor: '#8234db55',
        strokeColor: '#8234db',
        offset: [0,0],
        markerTemplate: 'islands#violetStretchyIcon'
    },
    {
        polygonCoordinates: [
            [52.09411387144938,23.760914859539838],
            [52.09414856449737,23.761108649141264],
            [52.093873910460026,23.761242089039882],
            [52.09384949094939,23.76110772713164],
            [52.09364174387055,23.761210122877092],
            [52.093602868625496,23.761001528418664],
            [52.093860900489524,23.760874961681132],
            [52.09388919200728,23.76102684176612],
            [52.09411387144938,23.760914859539838]
        ],
        name: 'Общежитие №4',
        textCoordinates: [52.093848452917825,23.76100198623656],
        fillColor: '#8234db55',
        strokeColor: '#8234db',
        offset: [0,0],
        markerTemplate: 'islands#violetStretchyIcon'
    },
]

var categoriesIsVisible = {
    coffeepoints: false,
    canteens: false,
    buffets: false,
    printing_points: false,
    deans: false
};

var placesIsVisible = false;

function init() {
    const myMap = new ymaps.Map("map", {
        center: [52.095648, 23.758507],
        zoom: 17	
    });

    myMap.controls.remove('searchControl'); // удаляем поиск
    myMap.controls.remove('trafficControl'); // удаляем контроль трафика
    myMap.controls.remove('fullscreenControl'); // удаляем кнопку перехода в полноэкранный режим
    myMap.controls.remove('zoomControl'); // удаляем контрол зуммирования
    //myMap.controls.remove('geolocationControl'); // удаляем геолокацию
    //myMap.controls.remove('rulerControl'); // удаляем контрол правил
    //myMap.behaviors.disable(['scrollZoom']); // отключаем скролл карты (опционально)


    function showMarkers(category) {
        
        if (categoriesIsVisible[category]) {
            categoriesData[category].forEach((item) => {
                myMap.geoObjects.each((geoObject) => {
                    if (geoObject.geometry.getCoordinates()[0] === item.lat && geoObject.geometry.getCoordinates()[1] === item.lon) {
                        myMap.geoObjects.remove(geoObject);
                    }
                });
            });
            categoriesIsVisible[category] = false;
        } else {
            categoriesData[category].forEach((item) => {
                const placemark = new ymaps.Placemark([item.lat, item.lon], {
                    balloonContentHeader: item.name,
                    balloonContentBody: item.photo,
                    balloonContentFooter: item.description+item.work_time,
                    hintContent: item.hint
                },
                {
                    iconLayout: 'default#image',
                    iconImageHref: item.icon,
                    iconImageSize: [25, 25],
                    iconImageOffset: [0, 0]
                }
                );

                myMap.geoObjects.add(placemark);
            });
            categoriesIsVisible[category] = true;
        }
    }

    const categoryButtons = document.querySelectorAll('.category_button');
    categoryButtons.forEach((button) => {
        button.addEventListener('click', (e) => {
            const category = e.currentTarget.dataset.category;
            toggleCategory(button, category);
        });
    });

    function toggleCategory(button, category) {
        const isActive = button.classList.toggle('active');
        showMarkers(category);
    }

    var addedPolygons = [];
    var addedLayouts = [];

    var customLayout = ymaps.templateLayoutFactory.createClass(
        '<text style="color: #484646;">$[properties.iconContent]</text>'
    );

    document.getElementById('togglePolygons').addEventListener('change', function() {
        if (this.checked) {
            polygonData.forEach((item) => {
                var myGeoObject = new ymaps.GeoObject({
                    geometry: {
                        type: "Polygon",
                        coordinates: [
                            item.polygonCoordinates,
                            []
                        ],
                        fillRule: "nonZero"
                    },
                    properties:{
                        balloonContentHeader: item.name,
                        hintContent: item.name
                    }
                }, {
                    fillColor: item.fillColor,
                    strokeColor: item.strokeColor,
                    opacity: 0.75,
                    strokeWidth: 2,
                    strokeStyle: 'shortdash'
                });
                
                var myLabel = new ymaps.Placemark(
                    item.textCoordinates,
                    {
                        iconContent: item.name,
                    },
                    {
                        preset: item.markerTemplate,
                        //iconLayout: customLayout,
                        //iconOffset: item.offset
                    }
                );

                addedLayouts.push(myLabel);
                myMap.geoObjects.add(myLabel);

                addedPolygons.push(myGeoObject);
                myMap.geoObjects.add(myGeoObject);
            });
        } else {
            addedPolygons.forEach((polygon) => {
                myMap.geoObjects.remove(polygon);
            });
            addedPolygons = [];

            addedLayouts.forEach((layout) => {
                myMap.geoObjects.remove(layout);
            });
            addedLayouts = [];
        }
    });
};

ymaps.ready(init);