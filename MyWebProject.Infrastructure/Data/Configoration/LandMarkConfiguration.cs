﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using My_Web_Project_LandMarks_.Infrastructure.Data.Models;

namespace MyWebProject.Infrastructure.Data.Configoration
{
    public class LandMarkConfiguration : IEntityTypeConfiguration<LandMark>
    {
        public void Configure(EntityTypeBuilder<LandMark> builder)
        {
            builder.HasData(Landmarks());
        }

        private List<LandMark> Landmarks()
        {
            List<LandMark> landMarks = new List<LandMark>()
            {
                new LandMark()
                 {
                       Id = 24,
                       Name = "НДК",
                       Description = "Националният дворец на културата (НДК) се намира в самия център на София." +
                       "Това е най-големият комплекс за провеждане на конференции, специални събития и изложения в югоизточна Европа." +
                       "Състои се от осем етажа и три подземни нива, които включват 13 зали, и 55 помещения за конференции с капацитет от 100 до над 3000 места." +
                       "Изграждането на НДК е кулминационна част от инициативите за отбелязването през 1981 г. на 1300 години от създаването на българската държава." +
                       "Най-голямата зала в комплекса (Зала 1) има 3380 седящи места.",
                       Rating = 7.4m,
                       TownId = 1,
                       CategoryId = 6,

                 },
                new LandMark()
                {
                    Id = 25,
                    Name = "Царски дворец",
                    Description = "Информация за Царски дворец - София (музей и галерия) Бившият царски дворец можете да посетите в центъра на София." +
                    "Днес сградата е намерила приложение като Националната художествена галерия и Националния етнографски музей." +
                    "Преди построяването на сградата на нейно място се е намирал конак." +
                    "По време на Освобождението постройката е функционирала с медицинска цел." +
                    "След септември 1946 г една от залите на Двореца е била преобразувана в кабинет на министър-председателя Георги Димитров," +
                    "в следствие на което е бил направен ремонт.",
                    Rating = 9.0m,
                    TownId = 1,
                    CategoryId = 6,
                   
                    
                },
                new LandMark()
                {
                    Id = 3,
                    Name = "Храм-паметник Свети Александър Невски",
                    Description = "Храм-паметникът Свети Александър Невски е архитектурна забележителност и се намира в центъра на София. " +
                    "Побира 5000 души, а височината му е 53 м." +
                    "Звънът на камбаните ечи в радиус от 15 км. Отличава се с позлатените си куполи, които са покрити с 8,35 кг злато. " +
                    "Храмът е построен през 1912 г. в чест на руския император Александър II, известен като Цар Освободител." +
                    " В Криптата му се помещава иконна сбирка.",
                    Rating = 10.0m,
                    TownId = 1,
                    CategoryId = 6,
                   
                },
                new LandMark()
                {
                    Id = 4,
                    Name = "Народен театър Иван Вазов",
                    Description = "Информация за Народен театър Иван Вазов." +
                    "Народният театър Иван Вазов в град София е построен по проект на немски архитект и е първата театрална сцена на България и национален културен институт. " +
                    "Впечатляващата сграда на театъра е създадена в периода 1924-1928 г. За театъра се доставя специална механизация, " +
                    "каквато имат само най-престижните театри в света. " +
                    "В репертоара на театъра може да видите произведения на най-видните представители както на класиката, така и на съвременната световна и българска драматургия.",
                    Rating = 9.1m,
                    TownId= 1,
                    CategoryId = 6,
                },
                new LandMark() 
                {
                    Id = 5,
                    Name = "Античен театър",
                    Description = "Античният театър на Филипополис е сред най-добре запазените антични театри в света и сред основните туристически атракции на Пловдив. " +
                    "Построен е по времето на римския император Марк Улпий Траян сл. Хр. и е разкрит при археологически разкопки от 1968 до 1979 г. от Археологически музей Пловдив. " +
                    "Разположен е между Джамбаз тепе и Таксим тепе. " +
                    "Театърът на Филипопол e единствената запазена антична театрална сграда по българските земи. " +
                    "Сградата е адаптирана за съвременния културен живот на Пловдив и в нея се провеждат различни по характер спектакли за около 3500 зрители. " +
                    "Обявен е за археологически паметник в брой. 6 на Държавен вестник от 1995 г. " +
                    "Античният театър е известен погрешно като „Амфитеатъра“, което е друг вид антична постройка.",
                    Rating= 5.9m,
                    TownId= 2,
                    CategoryId = 6,
                },
                new LandMark() 
                {
                    Id = 6,
                    Name = "Регионален етнографски музей",
                    Description = "Регионален етнографски музей в Пловдив е вторият по големина в България специализиран музей за етнография с " +
                    "утвърдена научно-образователна дейност и център за културен туризъм. " +
                    "Помещава се в Куюмджиевата къща – Паметник на културата от национално значение.",
                    Rating = 4.9m,
                    TownId= 2,
                    CategoryId= 6,
                },
                new LandMark()
                {
                    Id = 7,
                    Name = "Небет Тепе",
                    Description = "Небет тепе е едно от днешните шест тепета, " +
                    "запазили се до наши дни, около които е построен град Пловдив. " +
                    "Заедно с Джамбаз тепе и Таксим тепе формира Трихълмието, днес по-известно като Старинен Пловдив, " +
                    "на което е бил разположен античният град. " +
                    "Археологическият комплекс „Небет тепе“ е признат за паметник на културата от национално значение. " +
                    "В него са разкрити останки от първото праисторическо селище, което датира от каменно-медната епоха.",
                    Rating = 9.3m,
                    TownId= 2,
                    CategoryId= 6,
                },
                new LandMark() 
                {
                    Id = 8,
                    Name = "Капана",
                    Description = "Капана е квартал в град Пловдив, в същинския център на града. " +
                    "Създаден като средище на занаятчии около Куршум хан, " +
                    "кварталът е особена плетеница от малки улички, носещи подобаващи имена – Железарска, Кожухарска, " +
                    "Абаджийска, Златарска и пр. По-известни забележителности около квартала са Джумая джамия, " +
                    "Римският стадион, Старият град.",
                    Rating = 10m,
                    TownId= 2,
                    CategoryId= 6,
                },
                new LandMark() 
                {
                    Id = 9,
                    Name = "Кайлъка",
                    Description = "„Кайлъка“ е парк, който се намира на юг от центъра на град Плевен. Скътан е сред чудно хубава каменна долина, покрай двата бряга на пенливата река Тученица. " +
                    "Кайлъка е възхитителен природен кът, който пленява със своята прелест и дивна естествена красота. " +
                    "Природата е била безгранично щедра към тази местност. " +
                    "Наречен е с турското име Кайлък, което е превод на по-старото българско име Каменец или Каменна долина. " +
                    "В началото на парка се намират развалините на късно античната крепост Сторгозия." +
                    "Кайлъка е майсторски моделиран от природата. Разположен е на около 10 хил. дка в карстовата долина на река Тученица. " +
                    "Столетия наред реката е прорязала варовиковите скали и е образувала малък пролом с успоредни отвесни канари, високи 20 – 30 метра една от друга на разстояние 100 – 150 метра. " +
                    "Естественият каньон на реката е приютил богата и разнообразна флора и фауна, където се срещат уникални за България и Балканския полуостров растения, " +
                    "а много от птиците и бозайниците са включени в червената книга на България",
                    Rating = 10.0m,
                    TownId= 3,
                    CategoryId= 6,
                },
                new LandMark() 
                {
                    Id = 10,
                    Name = "Панарамата",
                    Description = "Панорамата „Плевенска епопея 1877 г.“ е художествен музей в Плевен, " +
                    "построен в чест на 100-годишнината от Освобождението на Плевен от османско владичество." +
                    "В първите 3 години след нейното откриване панорамата е посетена от 2,5 милиона души. " +
                    "Тя е сред почти 200-те паметници, построени от плевенчани в памет на загиналите руснаци, " +
                    "румънци и българи. Включена е в Стоте национални туристически обекта." +
                    "Изградена е в района на „Скобелевия парк“, непосредствено до редута „Кованлък“, " +
                    "където по време на 3-та атака от Обсадата на Плевен се водят едни от най-тежките сражения." +
                    " Автори на проекта са архитектите Иво Петров и Пламена Цачева, заедно с проектантски екип от 14 души." +
                    "Автор на живописната част и главен изпълнител е Николай Овечкин (Военно студио „М. Греков“, Москва). " +
                    "Колектива е от 13 руски и български художници: Г. Талев, В.Щербаков, И. Кабанов, А. Чернишов, М. Ананиев, Н. Овечкин, Д. Дончев, В. Есаулов, В. Лемешев, Хр. Бояджиев, Г. Есаулов, В. Таутиев, Ю. Усипенко и А. Троценко." +
                    "Архитектурното тяло на Панорамата е направено да изглежда повдигнато върху 4 щика, които олицетворяват силата на оръжието, донесло свободата. " +
                    "Щиковете носят 4 хоризонтално разположени пръстена, 3 от които символизират 3-те атаки срещу Плевен, а 4-тият пръстен е декоративно-пластичен фриз символизиращ обсадата на Плевен." +
                    "Туристите могат да се изкачат по асансьори на 2 зрителни площадки на покрива на музея, " +
                    "откъдето могат да наблюдават историческите места: „Мъртвата долина“, редутите „Кованлък“ и „Исса ага“, Костницата в „Скобелевия парк“, " +
                    "Радишевските и Гривишките възвишения.Тържественото му откриване е на 10 декември 1977 г., в деня на стогодишнината от освобождението на Плевен.",
                    Rating = 9.9m,
                    TownId= 3,
                    CategoryId= 6,
                },
                new LandMark() 
                {
                    Id = 11,
                    Name = "Регионален Исторически Мозей",
                    Description = "Музеят се намира в централната част на град Плевен, улица „Стоян Заимов“ 3." +
                    "Регионалният исторически музей води началото си от основаното през 1903 година Археологическо дружество в града," +
                    " което създава своя сбирка от предмети, първите от тях разкрити при разкопки в крепостта Сторгозия. " +
                    "През 1923 година сбирката е изложена в сградата на читалище „Съгласие“, а през 1953 година музеят става самостоятелна институция. " +
                    "През 1984 година е преместен в сегашната си сграда за честването на „1300 годишнината от създаването на Българската държава“." +
                    "Основният фонд на музея включва над 180 000 музейни единици. " +
                    "Специализираната библиотека на музея разполага с над 10 000 тома научна литература и периодични издания." +
                    "Сред функциите на музея са издирване, проучване, представяне, опазване и популяризиране на паметниците на културата, " +
                    "природните образци, флората и фауната на територията на Област Плевен и Област Ловеч. " +
                    "В този район са разкрити значими археологически обекти от праисторията – работилницата за мустериенски върхове от с. Муселиево, праисторическото селище до с. Телиш; античността – римският град Улпия Ескус в село Гиген, " +
                    "Късноантичен град Долум – гр. Белене, Ад Путеа – с. Рибен, късноантичната и ранновизантийска крепост Сторгозия, Крепостта в Никопол.В музея има и природонаучна експозиция.",
                    Rating = 9.9m,
                    TownId= 3,
                    CategoryId= 6,
                },
                new LandMark()
                {
                    Id = 12,
                    Name = "Античен форум Августа Траяна",
                    Description = "Форумът на античния римски град Августа Траяна е археологически обект в централната част на град Стара Загора. " +
                    "Обектът е разкрит след строителни работи в района на Съдебната палата в града. " +
                    "Античният форумен комплекс е едно от най-монументалните съоръжения в римския град Августа Траяна." +
                    " Основател на града е император Траян (98-117г), " +
                    "откъдето идва и името му. Траян осъществява широкомащабна урбанистична дейност, " +
                    "но войната, която води през 114-117г на изток срещу Партското царство, му пречи да изгради града." +
                    "Истинското изграждане на Августа Траяна започва при император Марк Аврелий (161-180г). " +
                    "По негово време са изградени улична мрежа, водоснабдяване и канализация, обществено и жи­лищно строителство. " +
                    "Построени са и две крепостни стени, под­силени с около 40 бойни кули, от ко­ито досега са открити и проучени само 11. " +
                    "Открити са и две от портите на града - южната и западната. " +
                    "По същото време на града е предоставено правото да сече собствени емисии бронзови монети. " +
                    "Сеченето на монети продължава почти 100 години. Строят се още храмове, базилики, терми, портици, театрална сграда, тържища и др." +
                    "Най-голямо впечатление прави форумният комплекс, разположен до западната порта на града. " +
                    "Уникален елемент на този комплекс е амфитеатрално изграденият театрон с лице към площадното пространство на комплекса. " +
                    "Разполагал е с десет амфитеатрално подредени каменни седалки, които са били използвани от зрителите за наблюдение на тържества, " +
                    "събрания, шествия, гладиаторски борби и др.",
                    Rating = 9.1m,
                    TownId = 4,
                    CategoryId= 6,
                },
                new LandMark() 
                {
                    Id = 13,
                    Name = "Зоологическа градина",
                    Description = "Зоопаркът на Стара Загора е създаден на 26 април 1957 година. " +
                    "Разположен е в живописна местност на територията на парк Аязмото. Заема площ от 70 дка." +
                    "В него се отглеждат около 400 екземпляра от приблизително 80 вида бозайници, птици и земноводни. " +
                    "Могат да се видят животни от почти всички континенти: Европа – кафява мечка, благороден елен, сърна, рис, вълк, лисица, Азия – тигри, як, Северна Америка – енот, " +
                    "Южна Америка – ягуар, лама, Африка – лъв, щраус и Австралия – ему, папагали.",
                    Rating= 10,
                    TownId= 4,
                    CategoryId= 6,
                },
                new LandMark() 
                {
                    Id = 14,
                    Name = "Артилерийски парк",
                    Description = "Най-новият (изграден 2015г) и модерен парк в Стара Загора се намира в западната част на града. " +
                    "Изграден е върху 70 дка, на мястото на бившите артилерийски казарми. " +
                    "Тревните паркови площи са около 35 000кв.м. " +
                    "Засадени са много млади дървета, храсти и сезонни цветя, обособени са два алпинеума." +
                    "В парка е направен един централен шадраван - най-големият в Стара Загора. " +
                    "Той е облепен със стъклопластови плочки, а в целия кръг са разположени разпръсквачите за водните ефекти. " +
                    "Отделно са направени сухи шадравани (в западния и южния край) и японско езеро с градина." +
                    "В парка има още: детски площадки с площ над 1000кв.м. (отговарящи на най-съвременните изисквания за безопасност), " +
                    "четири спортни игрища за футбол на малки вратички,баскетбол, волейбол, бадминтон и тенис на корт, открита сцена за провеждане на различни прояви, мини зоопарк със различни видове птици." +
                    "Навсякъде средата е достъпна за хора с увреждания, като където се налага са изградени инвалидни рампи." +
                    "В югоизточната част на парка има паркинг за 200 автомобила.",
                    Rating= 10m,
                    TownId= 4,
                    CategoryId= 6,
                },
                new LandMark()  
                {
                    Id = 15,
                    Name = "Регионален исторически музей",
                    Description = "Регионалният исторически музей в Стара Загора се намира в центъра на града. " +
                    "В неговия фонд се пазят хиляди важни експонати. " +
                    "Витрините на музея проследяват историческите епохи. " +
                    "Районът на Стара Загора е обитаван от най-дълбока древност. " +
                    "Свидетелства за това могат да се видят в първата експозиционна зала на музея. " +
                    "Най-ранните следи от живот са от новокаменната епоха – VI хил. пр.н.е." +
                    "Специална карта показва местоположението на над 120 праисторически селищни могили, открити до момента в района около града, " +
                    "като пет от могилите се намират в границите на съвременния град. " +
                    "Изложени са сечива от рог, кост и кремък, керамични съдове с интересни форми и украси." +
                    " Римският период от историческото развитие на Старозагорския край започва през 46г н.е., когато районът е завладян от римляните." +
                    "През 107г, след победата си над даките, император Траян минал през този край и решил да построи тук град по римски образец, " +
                    "който нарича Августа Траяна. Градът е бил полуавтономен, имал е собствен градски съвет и народно събрание. " +
                    "От този период музеят пази впечатляващи експонати, открити при разкопки – стъкло, бронзови лампи, статуи, бижута, монети.",
                    Rating = 7.4m,
                    TownId= 4,
                    CategoryId= 6,
                },
                new LandMark() 
                {
                    Id = 16,
                    Name = "Бранителите на Стара Загора",
                    Description = "Внушителен е мемориалният комплекс Бранителите на Стара Загора, " +
                    "издигнат, за да напомня за битката от 31 юли 1877 година, когато българското опълчение, под развятото Самарско знаме, " +
                    "получава своето бойно кръщение. Всъщност високият 50-метров монумент наподобява именно развято знаме. " +
                    "В основите му е костницата на загиналите, гори и вечен огън в конструкция изпълнена под формата на щикове , " +
                    "а скулптурната композиция от шестима опълченци и руски офицер символизира 6-те български дружини, които за първи път влизат в бой под командването на руските офицери." +
                    "Самарското знаме е един от най-славните трикольори на Българската армия. Създадено от монахини от град Самара, " +
                    "то е дарено на опълченците по време на Руско-турската война. " +
                    "Много знаменосци загиват, но не позволяват то да попадне във вражески ръце." +
                    " След войната се пази в Радомир, откъдето е последният му знаменосец Никола Корчев.",
                    Rating = 6.1m,
                    TownId= 4,
                    CategoryId= 6,
                },
                new LandMark() 
                {
                    Id = 17,
                    Name = "Плаж Черноморец",
                    Description = "Плаж Черноморец се намира на около 15км южно от град Варна, " +
                    "между плажовете на Фичоза (на север) и Паша дере (на юг). " +
                    "В региона се намира защитената територия Ракитника и има много борови дървета. " +
                    "Брегът е стръмен и са се образували малки пясъчни плажове, а в морето има големи скали, паднали заради свлачища." +
                    " Плаж Черноморец е курортна местност край кв. " +
                    "Галата на Варна с едноименни къмпинг и хижа. " +
                    "Плаж Черноморец е известен с това име още от седемдесетте години на XXв." +
                    "Плаж Черноморец граничи с курортно селище Фичоза и местността Паша дере." +
                    " Редовни посетители на плажа е местното население, жителите на град Варна, " +
                    "които обичат природните изживявания са едни от редовните. Край него са разположени бунгала и почивни станции, " +
                    "предимно на предприятия от времето на социализма, както и на държавни институции." +
                    "Природата около плажа е непокътната, впечатление правят единствено руините останали от строежите преди 1990 година. " +
                    "Плажът разполага с барбекю, което посетителите, могат да използват.Плажната ивица е малка и спокойна сравнително чиста, " +
                    "въпреки че за нея отговарят главно посетителите.",
                    Rating = 10m,
                    TownId= 5,
                    CategoryId= 6,
                },
                new LandMark() 
                {
                    Id = 18,
                    Name = "Музей на изкуството на открито",
                    Description = "Музеят на изкуството на открито се намира в градинката до Художествената галерия в гр.Варна. " +
                    "Експозицията е инициатива на Община Варна, като в градинката са изложени редица скулптури, а идеята е да се излагат и нови. " +
                    "Една от последните придобивки е скулптурата Началото на младия автор Живко Дончев, която е с височина 1.80м. " +
                    "Скулптурата представлява идеята за първичния взрив. Затова е толкова динамична. " +
                    "За човешкия дух, за развитието напред във време и пространство., разказва авторът на произведението.",
                    Rating = 9.5m,
                    TownId= 5,
                    CategoryId= 6,
                },
                new LandMark() 
                {
                    Id = 19,
                    Name = "Малкият дворец",
                    Description = "Къщата е завършена през 1894г по поръчка на заможния варненски търговец Петко Бакърджиев, който по-късно се премества да живее в Цариград. " +
                    "В нея живее и един от кметовете на Варна - Теодосий Атанасов. " +
                    "С уреждането на статута на Морската градина като държавна собственост частният имот е отчужден с царски указ през 1929г. " +
                    "В края на 40-те години на миналия век директорът на Радио Варна - известният музикален деец Йордан Каранов, " +
                    "успява да издейства преместването на Радио Варна от сградата на пощата в част от Малкия дворец, както го наричат старите варненци. " +
                    "Изграден в стил неокласицизъм, по проект на един от най-добрите български архитекти - Никола Лазаров, " +
                    "този паметник на културата от национално значение впечатлява с красотата и изяществото си.",
                    Rating = 5.8m,
                    TownId= 5,
                    CategoryId= 6,
                },
                new LandMark()
                {
                    Id = 20,
                    Name = "Белинташ",
                    Description = "Белинташ (Беланташ, среща се и като Белънташ, а като малко по-остаряла форма и „Бели таши“) е скала с форма на малко плато в Родопите, " +
                    "носеща следи от човешка дейност. Предполага се, че това е култов обект, датиращ от енеолита, " +
                    "който е бил използван за ритуални нужди от населяващите района племена, " +
                    "като самата му същност и предназначение все още не са напълно изяснени." +
                    "Белинташ означава „Белият камък“ и идва от прилагателното „бял“, което, " +
                    "благодарение на тройното членуване в родопския диалект, се произнася „белиън, белън“ и турцизмът „таш“ (камък)." +
                    "Според тълкуванието на краеведа Никола Боев (която не се споделя от българските археолози и историци), топонимът Белинташ може да се преведе като „камъкът на войната“." +
                    " Боев свързва името със свещената война за главното светилище на Сабазий/Дионис в Родопите, водена от владетеля жрец на тракийското племе беси – Вологез." +
                    "Според народни предания мястото носи името на сподвижник на Караджа войвода, носил името Бельо (Белю) войвода." +
                    "Светилището Белинташ е разположено високо в планината над селата Мостово, Тополово и Долнослав. Смятано е за второто по големина на територията на България (след Перперек) и има визуална и функционална връзка с" +
                    " енеолитния храмов комплекс край с. Долнослав. От хълмистата част на Тракийската низина го отделят последните високи планински хребети на Родопите, които според проф. Ана Радунчева са естествено комбинирани така, че образуват легнала по гръб мъжка фигура със скръстени на талията ръце и фалос, " +
                    "сочещ небето. Самото светилище е разположено на просторно каменно плато с формата на фуния, чиято най-ниска част завършва в тясно каменно дере. Върху най-високата част на платото е разположено своеобразното плато-олтар. То е дълго около 300 m, а скалите в основата му, гледани от север и при подходящо положение на слънцето, " +
                    "са оформени като исполинска фигура на легнал по корем лъв. Тази централна част на светилището се намира в средата на обширен кръг от по-високи планински масиви, характеризиращи се с две особености – че от всяка точка на външния кръг добре се вижда платото олтар и биха могли да се наблюдават всички церемонии, които са се извършвали на него и че именно най-високите хребети от този външен кръг се комбинират естествено така, " +
                    "че образуват още поне три легнали по гръб мъжки тела.",
                    Rating = 10m,
                    CategoryId= 5,
                    VideoURL ="https://www.youtube.com/watch?v=kOHCzCnsFkA&t=34s"
                },
                new LandMark() 
                {
                    Id = 21,
                    Name = "Кръстова гора",
                    Description = "Местоположение" +
                    "Разположена е в най-южната част на област Пловдив, в направление юг – изток, " +
                    "на територията на общините Лъки и Асеновград, между селата Белица и Мостово и Борово." +
                    "Тръгвайки по пътека от Кръстов връх на запад, край него е голяма чешма с висок параклис, " +
                    "след 150 m се стига до манастирския комплекс, където най-забележителните обекти са църквата „Света Троица“ и монашеската сграда – всички на територията на община Лъки. " +
                    "На границата между общините има голям паркинг, до него на територията на община Асеновград са хотел-ресторант и останалите обекти от комплекса." +
                    "Местността е известна с намиращото се там християнско светилище на връх Кръста, което е християнски поклоннически център с международна известност. " +
                    "Особено популярен е при празнуване на християнския празник Кръстовден." +
                    "Местните хора разказват за Йордан Дрянков, родом от село Ковачевица, Гоцеделчевско. " +
                    "Отказал се от рано от светски изгоди и земни блага, Йорданчо, както го наричали някога, " +
                    "се посветил на Господ. Често получавал видения, едно от които след нощ прекарана на връх Кръстов. " +
                    "В това по-особено видение му се разкрива историята на мястото." +
                    "На този връх се е издигал голям манастир, в който се пазела частица от Кръста Господен. " +
                    "Преди това тази частица, която била прикрепена към кръст или от нея бил направен кръст, " +
                    "се пазела в Цариград в султанската съкровищница. Руският цар изпратил пратеници с богати дарове за султана, " +
                    "като им поръчал: „Като поиска султанът и той да ви даде подаръци за мене, вие му кажете, че вашият цар не иска нищо друго освен дървения кръст, " +
                    "който е научил, че се пази в съкровищницата ви.“ Пратениците изпълнили поръката на царя и султанът им дал искания кръст. " +
                    "Майката на султана, като научила за това, му рекла: „Какво си направил? Знаеш ли, че този кръст крепеше властта и силата ти" +
                    " Пусни потери да хванат пратениците и си го вземи.“" +
                    "Султанът изпратил хора, но не могли да хванат пратениците, " +
                    "защото, като узнали че ги търсят, не се върнали по същия път, а се отправили към Средните Родопи. " +
                    "В манастира на Кръстов връх русите предали на монасите кръста и заминали за Русия. " +
                    "Не след дълго манастирът бил нападнат от турците и разрушен до основи, а монасите са избити. " +
                    "Те успели обаче да скрият кръста в подземното манастирско скривалище.",
                    Rating = 9.7m,
                    CategoryId= 5,
                    VideoURL = "https://www.youtube.com/watch?v=Wk4CJC3-yms&t=197s"
                },
                new LandMark() 
                {
                    Id = 22,
                    Name = "Караджов камък",
                    Description = "Местността и едноименният връх „Караджов камък“ се намират в непосредствена близост до село Мостово в Западните Родопи." +
                    "Представлява високо скално плато (връх с височина 1448 m), в чиито отвесни стени се е образувал естествен тесен улей, в който е заклещен огромен камък – т. нар. " +
                    "Караджов камък. Територията на едноименното скално плато е обявена за защитена местност със Заповед № РД 1015 от 6 август 2003 г." +
                    " По време на археологическо проучване, ръководено от д-р Иван Христов (НАИМ при БАН) през 2003 г. е установено, " +
                    "че Караджов камък е изпълнявал функцията на светилище през ранната желязна епоха и късната античност." +
                    "Връх Караджов камък (1448 m н.в.) е разположен в най-югоизточната част на рида Градище в Родопите. Мястото представлява високо скално плато със стръмни отвесни скали, високи над 100 m. " +
                    "Платото заема площ от 4550 m². По цялото плато има десетки ями с естествен произход, но дообработени от човешка ръка. " +
                    "Единственият подход към платото е от югозапад през скален процеп, наречен от местните Боаза (Процеп). " +
                    "Процепът е висок 18 m и в горната му част се забелязват около 10 издълбани стъпки, силно измити от течащите дъждовни води." +
                    "Първите археологически проучвания на платото са осъществени едва през 2004 г. от екип на археолога д-р Иван Христов. " +
                    "Три сондажа са разположени в ниските части, между изпъкнали над околния терен скали. Установено е, че между скалите, " +
                    "върху които са издълбани улеи и ями, " +
                    "ритуално са били полагани огромно количество фрагменти от керамични съдове. " +
                    "Керамиката, намерена на обекта, е датирана от археолозите към втората фаза на ранната Желязната епоха (VIII – VI в. пр. Хр.)" +
                    "Христов датира съществуването на светилището основно в два периода – първият в ранножелязната епоха, а вторият – от края на III в. до началото на IV в. (благодарение на нумизматичен материал, намерен край обекта). " +
                    "Разположението на светилището в района на Белинташ, обаче сочи по-ранна датировка, още в Новокаменната епоха и по-късното му преизползване от траките." +
                    "Както и при други древни светилища, тук се наблюдават няколко нива. Първото ниво се нарича Долна култова площадка, следват издълбани стъпала – преход към по-високата част, където в скалите има изсечени малки дупки.",
                     Rating = 7.1m, 
                    CategoryId= 5,
                    VideoURL = "https://www.youtube.com/watch?v=dz4uhD5sD44&t=15s"
                },
                new LandMark() 
                { 
                    Id = 23,
                    Name = "Дяволското Гърло",
                    Description = "Местонахождение" +
                    "Пещерата е разположена на 1,5 km северно от село Триград в Триградското ждрело в Родопите." +
                    "Името на пещерата идва от формата на бившия вход (сега – изход), наподобяващ дяволска глава. " +
                    "Старото ѝ име е Клокотник и идва от чуващия се на входа на пещерата грохот от вода." +
                    "Първият опит за проникване в пещерата е направен през 1962 г. от Радостин Чомаков, Никола Корчев и Елена Пъдарева. " +
                    "Тримата алпинисти достигат до Голямата зала на пропастта, след което правят опит да продължат надолу по пътя на реката. " +
                    "Недостигът на екипировка, както и липсата на опит осуетяват по-нататъшното проникване в пропастта." +
                    "Дяволското гърло е пропастна пещера, която е формирана вследствие на пропадането на земните пластове. " +
                    "Основната ѝ част е заета от голяма зала, в която се намира най-високият подземен водопад на Балканския полуостров." +
                    "Пещерата се е получила от река, падаща под земята от 42 m височина, образувайки огромна зала, наречена „Бучащата зала“. " +
                    "Дължината ѝ е 110 m, ширината – 40 m, а височината ѝ достига до 35 m. " +
                    "Това е най-голямата зала в българските пещери след входната зала на Деветашката пещера – в нея може да се побере напр. катедралата „Св. Александър Невски“. " +
                    "В пещерата се влиза през изкуствена галерия с дължина 150 m, през която се достига до основата на водното течение. Оттук 301 стъпала нагоре извеждат покрай подземния водопад през стария вход до повърхността. " +
                    "На близо 400 m от входа на „Дяволското гърло“ водите на подземнотечащата река се губят в сифон-галерия. Дължината на сифона е повече от 150 m, " +
                    "а след него по 60-метрова галерия подземната река напуска пещерата и излиза отново на повърхността през пещера." +
                    "Дяволското гърло дава начало на различни легенди от времето на траките. Една от тях говори, че именно тук Орфей се спуска в подземното царство на Хадес, за да спаси любимата си – Евридика.",
                     Rating = 6.1m,
                     CategoryId= 5,
                     VideoURL = "https://www.youtube.com/watch?v=6FmeTFGhofA"
                }
            };

            return landMarks;
        }
    }
}
