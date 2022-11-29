﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using My_Web_Project_LandMarks_.Infrastructure.Data.Models;
using MyWebProject.Infrastructure.Data.Models;
using static System.Net.WebRequestMethods;

namespace MyWebProject.Infrastructure.Data.Configoration
{
    public class TownConfiguration : IEntityTypeConfiguration<Town>
    {
        public void Configure(EntityTypeBuilder<Town> builder)
        {
            builder.HasData(CreateTowns());
        }


        private List<Town> CreateTowns()
        {
            List<Town> towns = new List<Town>()
            {
                new Town
                {
                    Id=1,
                    Name="София",
                    Description ="Со̀фия е столицата и най-големият град на България. Тя е на 13-о място по брой жители в " +
                    "Европейския съюз. Според ГРАО населението по настоящ адрес е 1 276 956 души, а по постоянен адрес е 1 383 435 " +
                    "души (към 15 септември 2022 г.).[2] Според резултатите от преброяването през 2011 г. населението на града е 1 291 591,[3] което представлява 17,5% от населението на България. София е разположена в централната част на Западна България, в Софийската котловина и е заобиколена от 5 планини: Витоша и Плана от юг, Софийската планина (част от Стара планина) от север, Люлин от запад, и Лозенската планина (част от Ихтиманска Средна гора) от изток." +
                    " Това я прави четвъртата по височина столица в Европа. Изградена е върху четирите тераси на река Искър и нейните притоци: Перловска и Владайска (Елешница). В централната градска част, както и в кварталите Овча купел, Княжево, Горна баня и Панчарево, има минерални извори. Климатът на София е умерено континентален.София е основен административен, индустриален, транспортен, културен и образователен център на страната, като в нея е съсредоточено 1/6 от промишленото производство на България." +
                    " Тук се намират също така Българската академия на науките, много университети, театри, кина, както и Националната художествена галерия, археологически, исторически, природонаучни и други музеи. На много места в центъра на града са запазени видими археологически паметници от римско време.[4]София носи името на късноантичната раннохристиянска съборна[5] църква на града „Света София“ (на гръцки Ἁγία Σοφία на латински: Sancta Sophia; или „Светата Премъдрост Божия“ (едно от имената на младия Исус Христос)). Празникът на града обаче е на 17 септември, когато Православната църква отбелязва Светите мъченици София," +
                    " Вяра, Надежда и Любов. Датата е определена за Празник на София с решение на Столичния общински съвет от 25 март 1992 г.София е обявена за столица на 3 април 1879 г. от Учредителното народно събрание по предложение на проф. Марин Дринов, като стар български град, отдалечен от турската граница и средищно разположен в българското етническо землище.[6]МестоположениеИсторическият център на София е разположен непосредствено на юг от центъра на Софийското поле, една от Задбалканските котловини, разположена между Западна Стара планина (Мургаш, Софийска планина и Три уши) на север и планините Люлин, Витоша," +
                    " Плана и Лозенска, части на Средногорската планинска система, на юг. Съвременният град заема значителна част от Софийското поле, като е развит в по-голяма степен на югоизток и югозапад от историческия център, достигайки ниските части на Витоша, но най-североизточните му квартали – Сеславци и Кремиковци – са разположени по склоновете на Стара планина.[26]Климат:София е разположена в умерения климатичен пояс и има влажен континентален климат с топло лято (Dfb климатичната класификация на Кьопен) – средните месечни температури падат под 0 °C и не надхвърлят 22 °C, като повече от 3 месеца имат средна температура над 10 °C.",
                    Location ="<div class=mapouter><div class=gmap_canvas><iframe width=600 height=500 id=gmap_canvas" +
                    "src=https://maps.google.com/maps?q=sofia&t=&z=13&ie=UTF8&iwloc=&output=embed" +
                    " frameborder=0" +
                    " scrolling=no marginheight=0 marginwidth=0></iframe><a href=https://123movies-to.org>" +
                    "</a><br><style>.mapouter{position:relative;text-align:right;height:500px;width:600px;}</style><a href=" +
                    "https://www.embedgooglemap.net>" +
                    "embed google maps in website</a><style>.gmap_canvas {overflow:hidden;background:none!important;" +
                    "height:500px;width:600px;}</style></div></div>"
                },

                new Town
                {
                    Id=2,
                    Name = "Пловдив",
                    Description = "Пло̀вдив е вторият по големина град в България с население от 367 214 души по настоящ адрес," +
                    " към 15 юни 2022 г.[2] Намира се в западната част на Горнотракийската низина, на двата бряга на река Марица." +
                    " Отстои на 15 km северно от Родопите и на 50 km южно от Стара планина. " +
                    "Градът е застроен в подножията на шест сиенитни хълма, поради което често е наричан „Градът под тепетата“. " +
                    "Пловдив е управленски център на област Пловдив, община Пловдив, община Марица, община Родопи и е най-голямото стопанско ядро на Южния централен район." +
                    "Пловдив е град на над 8000 години, чието минало може да се проследи от праисторията до наши дни. " +
                    "Първите неолитни поселения в границите на днешния град започват от VI хилядолетие пр.н.е.[3][4], а от каменно-медната епоха (IV-III хилядолетие пр.н.е.) животът в града не е прекъсвал, което го нарежда сред най-древните постоянно обитавани градове в света.[5][6][7][8] Запазени и консервирани са древни паметници като античния театър, римския одеон, агората (римския форум), римския стадион, късноантична сграда „Ейрене“, епископската базилика, малката базилика и други." +
                    "Градът е най-динамично развиващият се център в Южна България. Икономиката му се крепи на добре развитата многопрофилна индустрия, на услугите, туризма и информационните технологии.Пловдив е разположен в централната част на Горнотракийската низина. През него преминава река Марица – най-пълноводната река в България. Така по естествен начин градът се разделя на две части – северна и южна. На север от Марица е разположен единствено район „Северен“, известен още със старото си наименование Кършияка, " +
                    "а на юг се намира същинската част на града, включваща останалите пет района. Отстои на 15 km северно от Родопите и на 50 km южно от Стара планина. Градът се намира на 126 km от столицата София, на 381 km от Варна и на 255 km от Бургас.\r\nКлиматът е преходно-континентален, типичен за доста централни южни части на Европа. Средната годишна температура е 12,3 °С. Средната максимална температура през юли е 30,3 °С, а абсолютният максимум е измерен на 5 юли 2000 г.: 45 °С. " +
                    "Средната годишна минимална температура е 6,5 °С, а абсолютният минимум е минус 31,5 °С",
                    Location = "<div class=mapouter><div class=gmap_canvas><iframe width=600 height=500 id=gmap_canvas" +
                    "src=https://maps.google.com/maps?q=%D0%BF%D0%BB%D0%BE%D0%B2%D0%B4%D0%B8%D0%B2&t=&z=13&ie=UTF8&iwloc=&output=embed" +
                    "frameborder=0 scrolling=nomarginheight=0marginwidth=0></iframe><a href=https://123movies-to.org></a><br><style>." +
                    "mapouter{position:relative;text-align:right;height:500px;width:600px;}</style><a href=https://www.embedgooglemap.net" +
                    ">embed google maps in website</a><style>.gmap_canvas " +
                    "{overflow:hidden;background:none!important;height:500px;width:600px;}</style></div></div>"
                },

                new Town
                {
                    Id=3,
                    Name = "Плевен",
                    Description = "Плевен се намира в Северна България. " +
                    "Той е административен център на едноименните община Плевен и област Плевен, " +
                    "както и един от важните културни, образователни, икономически и транспортни центрове в страната. " +
                    "Плевен и неговата околност имат корени от дълбока древност и практически непрекъснато хилядолетно развитие." +
                    " Населението на града по данни на ГРАО към 15.09.2021 г. е 101 780 жители, което го прави седми по големина в Република България. " +
                    "Плевен е известен туристически център, наричан още „град на музеите“. " +
                    "В него са съсредоточени множество културно-исторически забележителности." +
                    "Местоположение:" +
                    "Плевен е разположен в централната част на Мизия, в западното подножие на Плевенските височини, " +
                    "Средната Дунавска равнина. Градът е почти равноотдалечен от река Дунав и Стара планина, " +
                    "с добри наземни връзки с най-големите български градове: София (163 km), Пловдив (194 km), Варна (302 km), Бургас (335 km), " +
                    "Русе (152 km), както и с Ловеч (35 km), а също и със земите на север от Дунав и други по-малки населени места в региона. " +
                    "Основен градообразуващ фактор още в древността е плодородната разливна долина на р. Тученица (Тученишка или Плевенска бара)." +
                    " Релефът в тази част на Дунавската равнина и съответно – добрите пътни връзки, " +
                    "улесняват изграждането и развитието на първоначално разпръснатите малки селища като важен пътен възел и център с добри показатели за икономически напредък на Древна Тракия, " +
                    "на Римската империя и на България." +
                    "Климат:" +
                    "Климатът на Плевен е умереноконтинентален.",
                    Location = "<div class=\"mapouter\"><div class=\"gmap_canvas\">" +
                    "<iframe width=\"600\" height=\"500\" id=\"gmap_canvas\" src=\"https://maps.google.com/maps?q=pleven&t=&z=13&ie=UTF8&iwloc=&output=embed\" " +
                    "frameborder=\"0\" scrolling=\"no\" marginheight=\"0\" marginwidth=\"0\"></iframe><a href=\"https://123movies-to.org\">" +
                    "</a><br><style>.mapouter{position:relative;text-align:right;height:500px;width:600px;}</style><a href=\"https://www.embedgooglemap.net\"" +
                    ">embed google maps in website</a><style>.gmap_canvas" +
                    " {overflow:hidden;background:none!important;height:500px;width:600px;}</style></div></div>"
                },
                new Town
                {
                    Id=4,
                    Name ="Стара Загора",
                    Description = "Ста̀ра Заго̀ра е град в Южна България, един от основните икономически центрове в страната, " +
                    "както и основен транспортен възел на Южна България. " +
                    "Той е център на едноименните община, област и регионална асоциация на общините РАО Тракия. " +
                    "Градът е шестият по големина в страната с население от 136 183 души по данни на ГРАО към 15.06.2022 г. и" +
                    " образува петата по големина градска агломерация в България с население от 213 444 жители (към септември 2007 г.)," +
                    " както и център на 5-ата по големина област в България с население към 31 декември 2016 г. от 321 377 души." +
                    " Стабилното икономическо развитие на региона му отрежда второ място по БВП на глава от населението в страната." +
                    "В града се намира най-старият в Тракия български театър – Драматичен театър „Гео Милев“, античният Форум на Августа Траяна, " +
                    "а на 14 km от центъра на града е разположен националният балнеологичен курорт Старозагорски минерални бани. " +
                    "През 1925 г. е открита втората след София опера в страната – Южнобългарската опера (днес Държавна опера Стара Загора), " +
                    "а през 1895 г. – първият градски парк от европейски тип в България – Аязмото. В града се намират още и Музеят на религиите и музей „Неолитни жилища“." +
                    "Градът е разположен в Старозагорското поле – източната част на Горнотракийската низина – между Сърнена Средна гора, " +
                    "Светиилийските възвишения, Манастирските възвишения, Сакар планина и Чирпанските възвишения, край река Бедечка със средна надморска височина 196 m. " +
                    "Намира се на 209 km по асфалтов път и 250 km по релсов път от София." +
                    "Климат" +
                    "Климатът на градската територия е преходноконтинентален с влияние от Средиземно море. " +
                    "През зимата времето е по-меко и по-топло в сравнение с градовете в Тракийска низина, тъй като Средна гора предпазва от студените северни и североизточни ветрове.",
                     Location = "<div class=\"mapouter\"><div class=\"gmap_canvas\"><iframe width=\"600\" " +
                     "height=\"500\" id=\"gmap_canvas\" src=\"https://maps.google.com/maps?q=stara%20zagora&t=&z=13&ie=UTF8&iwloc=&output=embed\"" +
                     " frameborder=\"0\" scrolling=\"no\" marginheight=\"0\" marginwidth=\"0\"></iframe><a href=\"https://123movies-to.org\">" +
                     "</a><br><style>.mapouter{position:relative;text-align:right;height:500px;width:600px;}</style><a href=\"https://www.embedgooglemap.net\"" +
                     ">embed google maps in website</a><style>.gmap_canvas {overflow:hidden;background:none!important;height:500px;width:600px;}" +
                     "</style></div></div>"
                },
                new Town 
                { 
                    Id=5,
                    Name = "Варна",
                    Description = "Ва̀рна е най-големият град в Североизточна България, разположен по бреговете на Черно море и Варненското езеро и е административен център на едноименните община и област. " +
                    "Той е най-големият град в Северна България и по българското Черноморие. Населението на града по сведения на ГРАО към 15 септември 2022 г. се изчислява на 348 668 души, " +
                    "което поставя Варна на трето място в България (след София и Пловдив)." +
                    " На територията му е разположено Адмиралтейството на Българската армия. Варна често е наричана „морска столица“ или „лятна столица на България“ и е важен туристически и просветен център, " +
                    "изходна точка за курортите по Северното Черноморие.В града се съхранява златно съкровище от халколита, " +
                    "за което до разкопките на Града на птиците край Пазарджик се смята, че е най-старото златно съкровище в света, дало име на т. нар. Култура Варна." +
                    " След като са направени разкопки в „града на птиците“ край Пазарджик, е установено, че откритото там обработено злато е с 200 – 300 г. по-старо от предметите във Варненския халколитен некропол." +
                    " Във Варна се провежда Международният балетен конкурс, състоящ се на всеки две години в Летния театър на Варна през летния сезон." +
                    "Варна е кандидат за Европейска младежка столица 2016 г. и Европейска столица на културата 2019 г. " +
                    "Побеждава в надпреварата за Европейска младежка столица през 2017 г.ckege Сред международните културни събития, които се провеждат в града, " +
                    "са фестивалите Варненско лято, Любовта е лудост, Златният делфин, Август в изкуствата, Видеохолика и други." +
                    "Град Варна е разположен във Варненската низина, на бреговете на Варненския залив и между Варненското езеро и Франгенското плато. Част от града е разположена южно от Варненското езиро и се свързва с централните му части през Аспаруховия мост. Варна заема площ от 238 km². Градът се намира на 441 km от столицата София, на 388 km от Пловдив и на 130 km от Бургас. Най-близкия областен град е Добрич, който се намира на 52 km.\r\nЮжно от протока, свързващ залива и езерото," +
                    " са разположени кварталите Аспарухово и Галата. На северния бряг се намират промишлената зона и пристанищният комплекс. " +
                    "Североизточно от тях са централната градска част с историческия център (т.нар. „Гръцка махала“) и централните плажове." +
                    "Климатът на Варна е с морско и континентално влияние. Средната януарска температура е 1,9 °С, средната юлска – 22,4 °С, средногодишната е 12,2 °С, абсолютната минимална температура е –19 °С, абсолютната максимална е 41 °С. Средните годишни валежи са 540,3 mm.",
                    Location = "<div class=\"mapouter\"><div class=\"gmap_canvas\"><iframe width=\"600\" height=\"500\" id=\"gmap_canvas\" " +
                    "src=\"https://maps.google.com/maps?q=varna&t=&z=13&ie=UTF8&iwloc=&output=embed\" frameborder=\"0\" scrolling=\"no\"" +
                    " marginheight=\"0\" marginwidth=\"0\"></iframe><a href=\"https://123movies-to.org\"></a><br><style>" +
                    ".mapouter{position:relative;text-align:right;height:500px;width:600px;}</style><a href=\"https://www.embedgooglemap.net\"" +
                    ">embed google maps in website</a><style>.gmap_canvas {overflow:hidden;background:none!" +
                    "important;height:500px;width:600px;}</style></div></div>"
                }
            };

            return towns;
        }

    }
}
