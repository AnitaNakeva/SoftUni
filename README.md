# Courses from my education at SoftUni:
- ### C# Web
- ### C# OOP
- ### JS Advanced

---------------------------------------------------------------------------------------------------------------------------------------------

<br/>

# Plans (from C# Web):

## Internet Explained

1. Packets <br/>

   - Всяко съобщение, файл или поток от данни се разбива на малки парченца, наречени пакети <br/>
   
   - Всеки пакет съдържа важна информация вътре в него, наречен header: <br/>
   
      - Откъде е дошъл <br/>
      - Накъде отива <br/>
      - Колко дълъг е <br/>
      
         - Ето как се знае, че пакетът е пълен <br/>
         - Всички пакети в съобщението са с еднакъв размер <br/>
         
      - Колко пакета има в общото съобщение <br/>

2. Internet Protocol (IP) <br/>

   - Всички устройства в интернет имат адреси, наричат се IP адреси <br/>
   
      - IP адресът е уникален за всеки компютър или устройство в мрежата <br/>
      
   - IPv4 <br/>

      - последователност от 4 трицифрени числа, разделени с точка - пр. 192.168.14.120 <br/>
      - Всяко число може да бъде число от 0 до 255 <br/>
      - IPv4 не е достатъчен за всички мрежови устройства, свързани към интернет <br/>
      
   - CIDR (Classless Inter-Domain Routing)
     
      - метод за представяне на IP адреси и техните съответни мрежови префикси
      - позволява по-ефективно използване на наличните IPv4 адреси
        
   - IPv6 <br/>
   
      - използва 128 бита – 340 уникални адреса <br/>
      - Тези 128 бита са организирани в осем 16-битови секции <br/>
      - Всеки 16-битов блок се преобразува в шестнадесетичен и е разделени с двоеточие - пр. 3FFE:F200:0234:AB00:0123:4567:8901:ABCD <br/>
      
   - DNS (Domain Name Server) <br/>
   
      - компютърен сървър или система от сървъри, които управляват база данни със записи за домейн имена и техните съответни IP адреси <br/>
      - отговорни са за превръщането на човешки разбираеми домейн имена като "www.example.com" в съответните им IP адреси, които са разбираеми за компютрите, които обработват трафика в мрежата <br/>
      - DNS сървърите се използват от устройства като компютри, мобилни телефони, рутери и други, за да намерят IP адресите на уебсайтове и други интернет ресурси, когато се осъществява връзка с тях по домейн име <br/>
      
   - TCP (Transmission Control Protocol) <br/>
   
      - използва процес, при който разглежда всички пакети в дадено съобщение и ги проверява <br/>
      - Използвайки информацията за заглавката във всеки пакет, той знае: <br/>
      
         - Колко са <br/>
         - Колко големи трябва да бъдат <br/>
         - В какъв ред трябва да бъдат пакетите <br/>
         - Използвайки този контролен списък, той е в състояние да пренарежда пакетите <br/>
         
      - TCP проверява дали всички пакети са <br/>
      
         - В правилния ред <br/>
         - Без никакви проблеми <br/>
         - След това удостоверява данните и пакетите се сливат заедно, за да се създаде отново оригиналният файл, който е бил на устройството на подателя <br/>
         
   - UDP (User Datagram Protocol) <br/>
   
      - прост, безсъстоятелен протокол за предаване на данни в интернет <br/>
      - в сравнение с TCP, UDP не осигурява надеждна връзка и не гарантира доставката на данните в правилния ред или без загуби <br/>
      - TCP поставя надеждността с по-висок приоритет от скоростта <br/>
      - когато надеждността не е толкова важна, колкото скоростта, се използва UDP <br/>
      
   - QUIC (Quick UDP Internet Connections) <br/>
   
      - мрежов протокол, който комбинира предимствата на UDP с механизми за сигурност, точност и надеждност, подобни на тези на TCP <br/>

3. OSI (Open Systems Interconnection) моделът <br/>

   - референтна моделна архитектура, която описва начина, по който различните компютърни системи взаимодействат помежду си <br/>
   
   - OSI моделът е разделен на седем нива или слоя, като всеки слой извършва конкретни функции и комуникира със съседните си слоеве. Всеки слой предлага определени услуги на горния си съсед и използва услугите на слоя под него <br/>
   
   - слоеве: <br/>
   
      - 1.Физически слой (Physical Layer): Този слой се грижи за физическата връзка между устройствата. Той дефинира хардуерните компоненти и физическите характеристики на връзката, като например кабелите, конекторите, сигналите и техните характеристики. Примери: Ethernet, USB, Bluetooth, 802.11a/b/g/n <br/>
      
      - 2.Слой за връзка данни (Data Link Layer): Този слой осигурява надеждна връзка между съседни устройства в мрежата. Той дефинира начините за достъп до средата на предаване, контролира потока на данни и извършва детекция и корекция на грешки. Пример за протоколи: ATM, Ethernet, MAC <br/>
      
         - Medium Access Control (MAC) layer <br/>
         - Logical Link Control (LLC) layer <br/>
         
      - 3.Мрежови слой (Network Layer): Този слой се грижи за маршрутизацията на данните в мрежата. Той определя най-добрия път за предаване на данните от източника до дестинацията и осигурява маршрутизация и комутация на данните. Пример за протоколи: IP, IPv6, IPSec, ICMP, IGMP <br/>
      
      - 4.Транспортен слой (Transport Layer): Този слой осигурява надежден транспорт на данните между крайните устройства. Той контролира потока на данните, разделя ги на сегменти и гарантира тяхната доставка без загуби и в правилния ред. Пример за протоколи: TCP, QUIC, UDP. Важно понятие за уеб разработчиците е номерът на порта. <br/>
      
      - 5.Сесионен слой (Session Layer): Този слой управлява сесиите между устройствата. Той установява, управлява и завършва връзките между устройствата и осигурява синхронизация и възстановяване при грешки. Пример за протоколи: RPC, PPTP <br/>
      
      - 6.Приложен слой (Presentation Layer): Този слой се грижи за представянето на данните, така че те да бъдат разбирателни за приложенията. Той обработва форматирането, кодирането и превода на данните. Пример за протоколи: SSL, TSL <br/>
      
      - 7.Приложен слой (Application Layer): Този слой предоставя интерфейс за комуникация между потребителските приложения и мрежата. Той включва различни приложения като уеб браузъри, електронна поща, файлово споделяне и други. Пример за протоколи: DNS, FTP, HTTP, SMTP, POP3, IMAP <br/>

4. Network hardware <br/>

   - Basic Hardware Components <br/>
   
      - Cables - преносната среда за прехвърляне на данни от eдно устройство към друго <br/>
      - Routers - свързващо устройство, което прехвърля пакети с данни между различни компютърни мрежи (работи на ниво 3 на OSI) <br/>
      - Repeaters, Hubs and Switches - свързват мрежовите устройства заедно, за да могат да функционират като един сегмент <br/>
      
         - Repeater - получава сигнал и го регенерира преди препредаване, така че да може да пътува на по-дълги разстояния <br/>
         - Hub – многопортов repeater (работи на ниво 1 на OSI модела) <br/>
         - Switch - получава данни от порт, uses packet switching to resolve the destination device and forwards the data to the particular destination (работи на ниво 2 от модела OSI) <br/>
         
      - Bridges - свързват два отделни, но сходни Ethernet мрежови сегмента, препращат пакети от мрежовия източник към предназначената мрежа (работи на ниво 2 на OSI) <br/>
      - Gateways - свързва мрежи, които работят по различни протоколи, входната и изходната точка на мрежата (контролира достъпа до другите мрежи), ниво 4, 5, 6 или 7 на OSI модела (същото като Firewalls) <br/>
      - Network Interface Cards - NIC – компютърен компонент, който го свързва с мрежата. Има два вида мрежови карти <br/>
      
         - Вътрешния <br/>
         - Външен <br/>

----------------------------------------------------------------------------------------------------------------------------------------------------------------

<br/>

## HTTP Protocol

1. HTTP Basics <br/>

   - протокол - набор от правила, които oпределете как две или повече страни разговарят помежду си <br/>
   
   - HTTP - Hyper Text Transfer Protocol <br/>
   
      - HTTP (Hypertext Transfer Protocol) е протокол за пренос на данни в света на уеб страници и приложения. Той позволява браузърите да заявяват ресурси от уеб сървъри и да ги показват на потребителите <br/>
      - Протокол клиент-сървър с общо предназначение, използван за предаване на данни
в мрежата <br/>
      - Разчита на URL адреси <br/>
      - Всяка HTTP заявка е независима от останалите <br/>
      - HTTP request и HTTP response <br/>
      
   - URL - Uniform Resource Locator <br/>
   
      - адресът, който идентифицира уеб страница или друг ресурс в интернет <br/>
      - състои се от: <br/>
      
         - Network protocol (http, ftp, https...) – HTTP in most cases <br/>
         - Host or IP address (softuni.org, gmail.com, 127.0.0.1, web) <br/>
         - Port (the default port is 80) – integer in the range [0…65535] <br/>
         - Path (/forum, /path/index.php) <br/>
         - Query string (?id=27&lang=en) <br/>
         - Fragment (#slides) – navigate to some section in the page <br/>
         
      - Safe URL characters: [0-9a-zA-Z], $, -, _, . , +, *, ', (, ), ,, ! <br/>
      
2. HTTP Request <br/>

   - съобщение, което браузърът изпраща до уеб сървъра, когато потребителят иска да зареди определена уеб страница или ресурс <br/>
   
   - HTTP request line <br/>
   
      - Request method (GET / POST / PUT / DELETE / …) <br/>
      - Resource URI (URL) <br/>
      - Protocol version <br/>
      
   - HTTP request headers <br/>
   
      - Additional parameters <br/>
      
   - HTTP request body – optional data, e.g., posted form fields <br/>

3. HTTP Response <br/>

   - HTTP Response е съобщение, което уеб сървърът изпраща към браузъра в отговор на HTTP заявката, направена от браузъра <br/>
   
   - HTTP response status line <br/>
   
      - Protocol version <br/>
      - Status code <br/>
      - Status phrase <br/>
      
   - Response headers <br/>
   
      - Provide meta data about the returned resource <br/>
      
   - Response body <br/>
   
      - The content of the HTTP response (data) <br/>

4. WEB Routing <br/>

   - Уеб маршрутизацията (Web Routing) се отнася до процеса на определяне на начина, по който уеб приложението обработва заявките за различните URL адреси (уеб адреси). Например, ако потребител посети www.example.com/home, уеб маршрутизацията ще го насочи към функцията или контролера, отговарящи за изобразяването на началната страница на уеб сайта <br/>

5. HTTP/2 <br/>

   - HTTP/2 е протокол за предаване на данни през интернет, който замества HTTP/1.1. Той е създаден с цел да подобри скоростта и ефективността на зареждането на уеб страници чрез множество подобрения, като мултиплексиране на данни, компресия на заглавията, приоритизация на заявките и др <br/>
   
   - обработват се множество потоци през една TCP връзка <br/>

6. HTTP/3 <br/>

   - Той е базиран на протокола QUIC (Quick UDP Internet Connections) и има за цел да подобри скоростта и сигурността на уеб комуникациите <br/>

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

<br/>

## State Management & Asynchronous Processing

1. HTTP Cookies <br/>

   - HTTP бисквитките са малки парчета данни, които се изпращат от уебсайт и се съхраняват на устройството на потребителя, докато той разглежда уебсайта. Бисквитките се използват за запомняне на информация за потребителя и неговата дейност в мрежата, които могат да бъдат използвани от уебсайта при следващо посещение <br/>
      -Управление на сесии: влизания, колички за пазаруване, резултати от игри или нещо друго, което сървърът трябва да запомни <br/>
      -Персонализация: потребителски предпочитания, теми и други потребителски настройки <br/>
      -Проследяване: записване и анализиране на поведението на потребителите <br/>
   - The HTTP object is stateless <br/>
      ▪ It doesn't store information about the requests <br/>
      ▪ The server doesn't know if two requests come from the same client <br/>
   в) Cookies решават този проблем, като помагат да се помни: <br/>
      ▪ To know whether the user is logged in or not <br/>
      ▪ To know which account the user is logged in with <br/>
      ▪ To record the user's browsing activity <br/>
      ▪ To remember pieces of information previously entered into form fields (usernames, passwords, etc.) <br/>
   г) структура: <br/>
      ▪ The cookie consists of Name, Value and Attributes (optional) <br/>
      ▪ The attributes are key-value pairs with additional information <br/>
      ▪ Attributes are not included in the requests <br/>
      ▪ Attributes are used by the client to control the cookies <br/>
                              name=value                      attributes <br/>
         -пример: Set-Cookie: SSID=Ap4P…GTEq; Domain=foo.com; Path=/; <br/>
                  Expires=Wed, 13 Jan 2021 22:23:01 GMT; Secure; HttpOnly <br/>
         -Domain – defines the website that the cookie belongs to <br/>
         -Path – Indicates a URL path that must exist in the requested resource before sending the Cookie header <br/>
         -Expires - the lifetime (or we could use Max-Age) <br/>
         -Secure - tells the browser to use cookies only via secure/encrypted connections <br/>
         -HttpOnly – defines that the cookie cannot be accessed via client-side scripting languages <br/>
   д) Third Party Cookies <br/>
         ▪ Cookies stored by an external party (different domain) <br/>
         ▪ Mainly used for advertising and tracking across the web <br/>

2. Sessions <br/>
   a) Сесиите в уеб програмирането са периоди на активно взаимодействие между потребител и уебсайт <br/>
   б) Те обикновено започват, когато потребителят отвори уебсайт или приложение и продължават, докато той остане активен на уебсайта, обикновено с определен период на неактивност <br/>
   в) В рамките на една сесия уебсайтът запомня данни за потребителя, като например входни данни, предпочитания и други информации, които се използват през целия период на сесията <br/>
   г) Когато потребителят затвори браузъра си или се откаже от сесията, тя приключва <br/>
   г) Важно е да се отбележи, че сесиите могат да се управляват чрез HTTP бисквитки или други методи за запазване на състоянието (state) на потребителя <br/>

3. Session Vs Cookies <br/>
   a) session: Stored on the server <br/>
      cookies: Stored on the user's computer as a text file <br/>
    <br/>
   б) session: Expires when the user closes the browser <br/>
      cookies: Expires on its expiration date <br/>
    <br/>
   в) session: It can store an unlimited amount of data <br/>
      cookies: It can store only limited data <br/>
    <br/>
   г) session: Depends on the cookie <br/>
      cookies: Does not depend on the session <br/>
    <br/>
   д) session: Secure – saves data in encrypted form and cannot be accessed by anyone easy <br/>
      cookies: Have security issues, as data is stored in a text file and it can be accessed by anyone easily <br/>

4. Синхронно програмиране <br/>
   а) Синхронното програмиране е начин за изпълнение на код, където всеки ред от кода се изпълнява последователно, един след друг <br/>
   б) Когато се извиква функция или операция, програмата чака да приключи изпълнението й, преди да продължи напред <br/>
   в) Програмните ресурси са достъпни във всички точки <br/>

5. Асинхронно програмиране  <br/>
   а) Асинхронното програмиране е начин за изпълнение на код, при който програмата не чака завършването на определена операция, преди да продължи напред <br/>
   б) Вместо това, програмата продължава да изпълнява други задачи, докато изчаква завършването на тази операция <br/>
   в) Независимите компоненти не чакат един-друг <br/>
   г) Програмни ресурси, споделени между нишките <br/>
      -ако една нишка(thread) използва ресурси, други не трябва да ги използват <br/>
   д) по-трудно за дебъгване <br/>

6. Threads <br/>
   a) Thread (нишка) е независима пътека на изпълнение в рамките на една програма <br/>
   б) Всяка нишка представлява отделен поток на изпълнение, който може да изпълнява инструкции паралелно с други нишки в същата програма <br/>
   в) Използването на нишки позволява на програмата да изпълнява няколко задачи едновременно, което може да подобри ефективността и отзивчивостта й <br/>
   г) Нишките споделят общи ресурси като паметта и файловете, което позволява лесното им комуникиране помежду си <br/>
   д) Threads in C# can be created using the System.Thread class <br/>
      -Constructor accepts a method (delegate) to execute on a separate thread: <br/>
         пример:  <br/>
         Thread thread = new Thread(() => <br/>
         { <br/>
            for (int i = 0; i < 10; i++) <br/>
            { <br/>
               Console.WriteLine(i); <br/>
            } <br/>
         }); <br/>
   е) команди: <br/>
      ▪ Start() – schedules the thread for execution <br/>
      ▪ Join() – waits for the thread to finish its work (blocks the calling thread) <br/>
   ж) Each thread has its own stack <br/>
   з) A race condition occurs when two or more threads access shared data and they try to change it at the same time <br/>
   и) lock keyword grants access to only one thread at a time <br/>
      ▪ Avoids race conditions <br/>
      ▪ Blocks any other threads until the lock is released <br/>
         пример: <br/>
         lock (numbers) // <- референтен тип <br/>
         { <br/>
            if (numbers.Count == 0) break; <br/>
            int lastIndex = numbers.Count - 1; <br/>
            numbers.RemoveAt(lastIndex); <br/>
         } <br/>
   й) Exceptions cannot be handled outside a thread!! <br/>
   
7. Tasks <br/>
      а) Работи успоредно с основната нишка <br/>
      б) Може да не се изпълнява на нова нишка (CLR решава) <br/>
      в) Предлага няколко операции <br/>
         ▪ Създаване, изпълнение и връщане на резултат <br/>
         ▪ Продължаване с друга задача (свързване на няколко операции) <br/>
         ▪ Правилна обработка на изключенията <br/>
         ▪ Доклади за напредъка/състоянието <br/>
      г) инициализиране -> Task task = new Task(() => { Console.WriteLine(""); }); <br/>
                           Task.Run(() => TraverseMatrix()); <br/>
         -Task.Factory.StartNew() – enables additional task customization <br/>
                           Task.Factory.StartNew(() => CopyFileContents("got-s03ep1.avi"), TaskCreationOptions.LongRunning); <br/>
      д) Task<T> is a task that will return a result sometime in the future <br/>
      е) Exceptions that have occurred within the body of a Task can be captured and handled outside of it <br/>

8. Async and Await <br/>
      a) async - използва се за дефиниране на метод, който може да бъде изпълнен асинхронно <br/>
      б) await - използва се за изчакване на завършването на асинхронна операция, без да блокира основния поток на изпълнение <br/>
      в) С тях можем да пишем код, който изглежда синхронен, но използва асинхронни операции. Това прави кода по-четим и по-лесен за поддръжка, като същевременно подобрява отзивчивостта на приложението <br/>
      г) If it starts waiting, return to the calling method <br/>
         -When the wait is over, go back to called method <br/>































