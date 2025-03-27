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
   
      - Управление на сесии: влизания, колички за пазаруване, резултати от игри или нещо друго, което сървърът трябва да запомни <br/>
      - Персонализация: потребителски предпочитания, теми и други потребителски настройки <br/>
      - Проследяване: записване и анализиране на поведението на потребителите <br/>
      
   - The HTTP object is stateless <br/>
   
      - It doesn't store information about the requests <br/>
      - The server doesn't know if two requests come from the same client <br/>
      
   - Cookies решават този проблем, като помагат да се помни: <br/>
   
      - To know whether the user is logged in or not <br/>
      - To know which account the user is logged in with <br/>
      - To record the user's browsing activity <br/>
      - To remember pieces of information previously entered into form fields (usernames, passwords, etc.) <br/>
      
   - структура: <br/>
   
      - The cookie consists of Name, Value and Attributes (optional) <br/>
      - The attributes are key-value pairs with additional information <br/>
      - Attributes are not included in the requests <br/>
      - Attributes are used by the client to control the cookies <br/>
      
         - ...............................................name=value...................................attributes <br/>
         - пример: Set-Cookie: SSID=Ap4P…GTEq; Domain=foo.com; Path=/; <br/>
                  Expires=Wed, 13 Jan 2021 22:23:01 GMT; Secure; HttpOnly <br/>
         - Domain – defines the website that the cookie belongs to <br/>
         - Path – Indicates a URL path that must exist in the requested resource before sending the Cookie header <br/>
         - Expires - the lifetime (or we could use Max-Age) <br/>
         - Secure - tells the browser to use cookies only via secure/encrypted connections <br/>
         - HttpOnly – defines that the cookie cannot be accessed via client-side scripting languages <br/>
         
   - Third Party Cookies <br/>
   
      - Cookies stored by an external party (different domain) <br/>
      - Mainly used for advertising and tracking across the web <br/>

2. Sessions <br/>

   - Сесиите в уеб програмирането са периоди на активно взаимодействие между потребител и уебсайт <br/>
   
   - Те обикновено започват, когато потребителят отвори уебсайт или приложение и продължават, докато той остане активен на уебсайта, обикновено с определен период на неактивност <br/>
   
   - В рамките на една сесия уебсайтът запомня данни за потребителя, като например входни данни, предпочитания и други информации, които се използват през целия период на сесията <br/>
   
   - Когато потребителят затвори браузъра си или се откаже от сесията, тя приключва <br/>
   
   - Важно е да се отбележи, че сесиите могат да се управляват чрез HTTP бисквитки или други методи за запазване на състоянието (state) на потребителя <br/>

3. Session Vs Cookies <br/>

   - session: Stored on the server <br/>
     cookies: Stored on the user's computer as a text file <br/>
    <br/>
    
   - session: Expires when the user closes the browser <br/>
     cookies: Expires on its expiration date <br/>
    <br/>
    
   - session: It can store an unlimited amount of data <br/>
     cookies: It can store only limited data <br/>
    <br/>
    
   - session: Depends on the cookie <br/>
     cookies: Does not depend on the session <br/>
    <br/>
    
   - session: Secure – saves data in encrypted form and cannot be accessed by anyone easy <br/>
     cookies: Have security issues, as data is stored in a text file and it can be accessed by anyone easily <br/>

4. Синхронно програмиране <br/>

   - Синхронното програмиране е начин за изпълнение на код, където всеки ред от кода се изпълнява последователно, един след друг <br/>
   
   - Когато се извиква функция или операция, програмата чака да приключи изпълнението й, преди да продължи напред <br/>
   
   - Програмните ресурси са достъпни във всички точки <br/>

5. Асинхронно програмиране  <br/>

   - Асинхронното програмиране е начин за изпълнение на код, при който програмата не чака завършването на определена операция, преди да продължи напред <br/>
   
   - Вместо това, програмата продължава да изпълнява други задачи, докато изчаква завършването на тази операция <br/>
   
   - Независимите компоненти не чакат един-друг <br/>
   
   - Програмни ресурси, споделени между нишките <br/>
   
      - ако една нишка(thread) използва ресурси, други не трябва да ги използват <br/>
      
   - по-трудно за дебъгване <br/>

6. Threads <br/>

   - Thread (нишка) е независима пътека на изпълнение в рамките на една програма <br/>
   
   - Всяка нишка представлява отделен поток на изпълнение, който може да изпълнява инструкции паралелно с други нишки в същата програма <br/>
   
   - Използването на нишки позволява на програмата да изпълнява няколко задачи едновременно, което може да подобри ефективността и отзивчивостта й <br/>
   
   - Нишките споделят общи ресурси като паметта и файловете, което позволява лесното им комуникиране помежду си <br/>
   
   - Threads in C# can be created using the System.Thread class <br/>
   
      - Constructor accepts a method (delegate) to execute on a separate thread: <br/>
      
         пример:  <br/>
         Thread thread = new Thread(() => <br/>
         { <br/>
            for (int i = 0; i < 10; i++) <br/>
            { <br/>
               Console.WriteLine(i); <br/>
            } <br/>
         }); <br/>
         
   - команди: <br/>
   
      - Start() – schedules the thread for execution <br/>
      - Join() – waits for the thread to finish its work (blocks the calling thread) <br/>
      
   - Each thread has its own stack <br/>
   
   - A race condition occurs when two or more threads access shared data and they try to change it at the same time <br/>
   
   - lock keyword grants access to only one thread at a time <br/>
   
      - Avoids race conditions <br/>
      - Blocks any other threads until the lock is released <br/>
      
         пример: <br/>
         lock (numbers) // <- референтен тип <br/>
         { <br/>
            if (numbers.Count == 0) break; <br/>
            int lastIndex = numbers.Count - 1; <br/>
            numbers.RemoveAt(lastIndex); <br/>
         } <br/>
         
   - Exceptions cannot be handled outside a thread!! <br/>
   
7. Tasks <br/>

      - Работи успоредно с основната нишка <br/>
      
      - Може да не се изпълнява на нова нишка (CLR решава) <br/>
      
      - Предлага няколко операции <br/>
      
         - Създаване, изпълнение и връщане на резултат <br/>
         - Продължаване с друга задача (свързване на няколко операции) <br/>
         - Правилна обработка на изключенията <br/>
         - Доклади за напредъка/състоянието <br/>
         
      - инициализиране -> Task task = new Task(() => { Console.WriteLine(""); }); <br/>
      
        ..............................................Task.Run(() => TraverseMatrix()); <br/>
                          
         - Task.Factory.StartNew() – enables additional task customization <br/>
         
           Task.Factory.StartNew(() => CopyFileContents("got-s03ep1.avi"), TaskCreationOptions.LongRunning); <br/>
                           
      - Task<T> is a task that will return a result sometime in the future <br/>
      
      - Exceptions that have occurred within the body of a Task can be captured and handled outside of it <br/>

8. Async and Await <br/>

      - async - използва се за дефиниране на метод, който може да бъде изпълнен асинхронно <br/>
      
      - await - използва се за изчакване на завършването на асинхронна операция, без да блокира основния поток на изпълнение <br/>
      
      - С тях можем да пишем код, който изглежда синхронен, но използва асинхронни операции. Това прави кода по-четим и по-лесен за поддръжка, като същевременно подобрява отзивчивостта на приложението <br/>
      
      - If it starts waiting, return to the calling method <br/>
      
         - When the wait is over, go back to called method <br/>

--------------------------------------------------------------------------------------------------------------------------------------------------

 <br/>
 
## ASP.NET Core Introduction

1. ASP.NET Core
   
   - ASP.NET Core is a cross-platform open-source back-end development framework for C#

      - ASP.NET Core Web Pages: build simple Web apps <br/>
      - ASP.NET Core MVC: build server-side Web apps <br/>
      - ASP.NET Core Web API: build Web services and REST APIs <br/>

      - Приложенията на ASP.NET Core работят както на .NET Core, така и на .NET Framework
    
2. MVC Pattern
   
   - MVC (Model-View-Controller) е архитектурен модел за проектиране на софтуерни системи, който разделя приложението на три основни компонента:

      - Модел (Model): Представлява данните и бизнес логиката на приложението. Моделът обработва и управлява данните, както и всяка обработка или логика, свързани с тях. <br/>
      
         - Набор от класове, които описват данните, които се показват в потребителския интерфейс (UI) <br/>
         - Може да съдържа правила за валидация на данни <br/>
         - Моделите съдържат данни за приложението за изгледите, подготвени от контролерите <br/>
         - Два типа модели: <br/>
           
            - Модел за изглед / модел за свързване
              
               - Свързва UI на уеб страницата с клас на C# <br/>
               - Част от архитектурата на MVC <br/>
                 
            - Модел на база данни / домейн модел
              
               - Свързва таблица в базата данни с клас на C# (използвайки ORM)
                 
      - Изглед (View): Отговаря за визуализацията на данните към потребителя. Изгледът представлява информацията от модела по начин, който е подходящ за потребителския интерфейс (UI). <br/>

        - Изгледите показват HTML + CSS, базирани на моделите
          
      - Контролер (Controller): Приема потребителския вход и реагира на събития (като кликване на бутон или въвеждане на текст). Той е свързан с модела и изгледа и координира техните действия, за да отговори на потребителските заявки. <br/>
      
         - Всеки контролер има един или повече "Action" <br/>
         - Контролерите обработват HTTP GET / POST заявки и генерират изглед <br/>

   - MVC стъпки:
     
      - 1.Входяща заявка, препратена към контролера:

         - Когато потребител направи заявка към уеб приложението (например, чрез въвеждане на URL в браузъра), тази заявка се изпраща към съответния контролер в приложението.
           
      - 2.Контролерът обработва заявката и създава модел (модел за изглед):

         - Контролерът получава заявката и извлича необходимата информация от нея, като параметри, въведени от потребителя. След това той използва тази информация, за да създаде или подготви модела, който ще бъде изпратен на изгледа за визуализация.
           
      - 3.Контролерът избира подходящ резултат (например: изглед):

         - В зависимост от заявката и логиката на приложението, контролерът избира какъв тип резултат да върне. Например, той може да реши да върне специфичен изглед (HTML шаблон), JSON данни или друг вид резултат.
           
      - 4.Моделът се подава на изгледа:

         - След като контролерът е подготвил модела с необходимата информация, той го подава към изгледа, който ще го визуализира.
           
      - 5.Изгледът преобразува модела в съответния изходен формат (HTML):

         - Изгледът получава модела от контролера и използва специфични шаблони (например, Razor за ASP.NET приложения), за да генерира HTML код, който ще се покаже на потребителя. Той може да включва данни от модела, логика за изобразяване и структуриране на информацията.
           
      - 6.Отговорът се генерира (HTTP отговор):

         - След като изгледът е генерирал HTML от модела, този HTML код се връща като част от HTTP отговора към потребителя. Потребителят вижда визуализирания резултат на своята заявка в браузъра.
       
3. Създаване на приложение с ASP.NET Core MVC

   - Views
     
      - ASP.NET MVC използва Razor изгледов двигател - Изгледите комбинират HTML с код на C#
     
         - @ { ... } вмъква блок от код на C# <br/>
         - @Something извежда променлива на C# <br/>
         - Всичко друго е HTML код <br/>

   - Controllers
     
      - Всички контролери трябва да се намират в папката "Controllers" <br/>
      - Стандартът за именуване на контролери трябва да бъде {име}Controller <br/>
      - Всеки контролер трябва да наследява класа Controller <br/>
     
         - Достъп до Request, Response, HttpContext, RouteData, TempData и други
        
      - Routes избират контролери във всяка заявка

   - Actions

     - Actions обикновено връщат IActionResult <br/>
     - Action result = отговорът на контролера на заявката от браузъра <br/>

          - Представляват различни HTTP статус кодове <br/>
          - Наследяват базовия клас ActionResult <br/>

   - Action Selectors
  
      - ActionName(string name) <br/>
      - AcceptVerbs <br/>
        
         - HttpPost <br/>
         - HttpGet <br/>
         - HttpDelete <br/>
         - HttpOptions <br/>
           
      - NonAction <br/>
      - RequireHttps <br/>
        
      - пример:
        <br/>
       ```csharp
            public class UsersController : Controller 
            {  
                [ActionName("UserLogin")] 
                [HttpPost] 
                [RequireHttps] 
                public IActionResult Login( 
                     string username, string password) 
                { 
                   return Content("Logged in!"); 
                } 
            }
       ```

     - Action Parameters
    
         - ASP.NET Core maps the data from the HTTP request to action parameters in few ways
           
            - Routing engine can pass parameters to actions
              
               - Routing pattern: Users/{username}
              
            - URL query string can contain parameters
              
               - /Users/ByUsername?username=NikolayIT
                 
            - HTTP post data can also contain parameters

4. Views and Razor View Engine

   - Изгледите генерират HTML код за извиканото действие
     
   - Стандартът за именуване на изгледите е {ИмеНаДействието}.cshtml
     
   - Изгледите трябва да се поместват в папка "/Views/{ИмеНаКонтролер}"

   - Най-популярният view engine е Razor View Engine

   -  With ViewBag (dynamic type):
     
      - Action: ViewBag.Message = "Hello!"; <br/>
      - View: @ViewBag.Message <br/>
      
   - With ViewData (dictionary):
     
      - Action: ViewData["message"] = "Hello!"; <br/>
      - View: @ViewData["message"] <br/>

   - The @model directive makes the model available to the view - @model CustomerViewModel

5. ASP.NET Core MVC Routing

   - ASP.NET Core MVC Routing е механизъм за определяне на това как URL адреси се съпоставят с действията на контролерите в уеб приложението
     
   - ASP.NET Core MVC използва middleware за маршрутизация на клиентски заявки
  
   - Routes describe how request URL paths should be mapped to Controller Actions

        - Conventional Routing (Used by Default)

          routes.MapControllerRoute( <br/>
             name: "default", <br/>
             template: "{controller=Home}/{action=Index}/{id?}" <br/>
          ); <br/>

          - Will match a route like "/Cats/Show/1" <br/>
          - Will extract the route values <br/>
            
               { <br/>
                  controller = "Cats", <br/>
                  action = "Show", <br/>
                  id = "1" <br/>
               } <br/>

6. Static Files

   - Статичните файлове (static files) в уеб разработката се отнасят до файлове като HTML, CSS, JavaScript, изображения и други ресурси, които се обслужват направо от уеб сървъра на клиентския браузър без да претърпяват промени от страна на уеб приложението.
       
          app.UseStaticFiles(); - This will tell the ASP.NET Core App to serve the static files in the "wwwroot" directory

7. Dependency Injection

   - Dependency injection injects objects at runtime
     
      - Регистрирате определен клас услуга в класа Program
        
           services.AddTransient<DataService>();
     
      - По-късно внедрявате регистрирания клас във вашите контролери<br/>
        
       ```csharp
               public class ProductController : Controller
               {
                  public ProductController(DataService ds) {
                     // Use the injected object "ds"
                  }
               }
       ```
    
8. Model Binding

   - Model binding в ASP.NET Core MVC е процесът, чрез който фреймуъркът автоматично свързва данни от HTTP заявки към параметрите на методите за действия (actions) в контролерите. 

      https://mysite.com/posts/edit/6 --> public IActionResult Edit(int? id)

   - Model binding can look through several data sources per Request
     
      - Form values – POST Request parameters <br/>
      - Route values – The set of Route values provided by the Routing <br/>
      - Query strings – The query string parameters in the URL <br/>
      - Even in headers, cookies, session, etc. in custom model binders <br/>

      - Проверката на източниците на данни става в указания по-горе ред.

   - Когато моделното свързване в ASP.NET Core MVC се провали, фреймуъркът не хвърля грешка. Вместо това:

      - Всяко действие, което приема потребителски вход, трябва да провери дали свързването е успешно чрез ModelState.IsValid. <br/>
      - Всяко вписване в ModelState на контролера е ModelStateEntry, което съдържа свойство Errors. <br/>
      - Можете лесно да обхождате грешките в ModelState. <br/>
      <br/>
    ```csharp
        public MyController : Controller
         {
            IActionResult Index(MyInputModel input)
            {
                 if (ModelState.IsValid)
                 {
                     return View();
                 }
            }
         }
    ```

9. Model Validation

   - .NET ни предоставя абстрактно валидиране чрез атрибути:

      - Някои атрибути конфигурират валидирането на модела чрез ограничения подобно на валидирането на полета в базата данни. <br/>
      - Други прилагат шаблони към данните, за да наложат бизнес правила (кредитни карти, телефонни номера, имейл адреси и т.н.) <br/>

   - Attribute Description

      - [CreditCard]______________Validates the property has a credit card format <br/>
      - [Compare] ________________ Validates 2 properties in a model match. (Useful for password confirmation) <br/>
      - [EmailAddress] ___________ Validates the property has an email format <br/>
      - [Phone] __________________ Validates the property has a telephone format <br/>
      - [Range] __________________ Validates the property value falls within the given range <br/>
      - [RegularExpression] ______ Validates the data matches the specified regular expression <br/>
      - [Required] _______________ Makes the property required. Value cannot be null <br/>
      - [StringLength] ___________ Validates that a string property has at most the given maximum length <br/>
      - [Url] ____________________ Validates the property has a URL format <br/>


   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------
   <br/>

## ASP.NET Core Databases

Connection string: Server=(localdb)\\mssqllocaldb;Database=DbName;Trusted_Connection=True;MultipleActiveResultSets=true

1. Entity Framework Core: Overview

   - Entity Framework (EF) е стандартният ORM (обектно-релационен модел) фреймуърк за .NET.
     
   - Той предлага:

      - Запитвания и операции с данни
        
         - Използва LINQ за извършване на заявки и CRUD (създаване, четене, актуализиране, изтриване) операции.
           
      - Автоматично проследяване на промени
        
         - Следи автоматично промените в обектите в паметта.
           
      - Поддръжка на различни бази данни
        
         - Работи с много релационни бази данни чрез различни доставчици.
           
      - Отворен код
        
         - Е отворен код и има независим цикъл на издаване.
        
   - Тези характеристики правят EF мощен инструмент за работа с бази данни в .NET приложения.

2. Code First Approach

   - "Code First" означава първо да напишете .NET класовете, а след това Entity Framework Core (EF Core) да създаде базата данни въз основа на тези класове и техните връзки.

3. DbContext
   
   - Класът DbContext в Entity Framework Core представлява централната част от взаимодействието с базата данни в приложенията на .NET.
   
   - Той управлява моделните класове чрез DbSet<T>, позволява лесна навигация и операции с релации, управлява създаването и изтриването на бази данни, изпълнява LINQ заявки като SQL и поддържа проследяване на промените.

   - пример:

     public class ShoppingListDbContext : DbContext

   - Свойства на DbContext
     
      - База данни – методи EnsureCreated/Deleted, връзка с базата данни <br/>
      - ChangeTracker – съдържа информация за automatic change tracker<br/>
        <br/>
     
       ```csharp
            using Microsoft.EntityFrameworkCore;
            public class ShoppingListDbContext : DbContext
            {
                  public ShoppingListDbContext
                         (DbContextOptions<ShoppingListDbContext> options)
                                : base(options)
                                => Database.EnsureCreated();
       
                  public DbSet<Product> Products { get; set; }
                  public DbSet<ProductNote> ProductNotes { get; set; }
       
                  protected override void OnModelCreating(ModelBuilder builder)
                  {
                        builder.Entity<Product>()
                            .HasMany(p => p.ProductNotes)
                            .WithOne(r => r.Product);
                  }
            }
       ```

4. EF Core Configuration

   - трябва да се инсталират:
  
      Install-Package Microsoft.EntityFrameworkCore
      + Microsoft.EntityFrameworkCore.SqlServer
      + Microsoft.EntityFrameworkCore.Design
      + Microsoft.EntityFrameworkCore.Tools //миграциите

   - In ASP.NET Core connection string is in the appsettings.json file and has the following properties

   
      ```cs
     
      "ConnectionStrings": {
            "DefaultConnection": "Server=(localdb)\\mssqllocaldb;
                        Database=ShoppingList;Trusted_Connection=True;
                        MultipleActiveResultSets=true"}
     
      ```

   - Use the DbContext and tell it to use SQL with the connection string in the Program class

  
       ```csharp
   
            var connectionString = builder
                  .Configuration
                  .GetConnectionString("DefaultConnection");
   
            builder
                  .Services
                  .AddDbContext<ShoppingListDbContext>(
                           x => x.UseSqlServer(connectionString));
       
        ```

   - Database.EnsureCreated()

      - Когато създадете DB контекста, можете да използвате Database.EnsureCreated():

         - Това ще създаде DB и схемата, ако DB липсва.

      - EnsureCreated() не използва миграции → трябва да изтриете целия DB, когато променяте схемата на DB.

5. Database Migrations

   - автоматизиран процес за управление на промените в схемата на база данни. 

   - за да добавим Миграция, използвайки the Package Manager Console
     
              Add-Migration {MigrationName}
   
   - за да я изтрием
     
              Remove-Migration

   - за да комитнем промените
  
              Update-Database

   - db.Database.Migrate();
  
        - Когато извикаме db.Database.Migrate() в Entity Framework Core:

            - Проверява съществуването на базата данни.
            - Прилага всички миграции, които са създадени за текущия модел на данните.
            - Ако базата данни не съществува, създава я и прилага всички миграции.

--------------------------------------------------------------------------------------------------------------------------------------------------

 <br/>
 
## ASP.NET Core Identity

1. Аутентикация (Authentication):

   - Аутентификацията е процесът на проверка на идентичността на потребителя.
   
   - Аутентификацията включва следните стъпки:

      - Въвеждане на идентификационни данни - Потребителят въвежда потребителско име и парола, биометрични данни или използва друг метод за идентификация (като смарт карта, токен и т.н.).
      - Проверка на идентификационните данни - Системата проверява дали предоставените идентификационни данни съответстват на запазените данни в базата данни.

   - Примери за методи на аутентификация включват:

      - Пароли
      - Биоидентификация (пръстови отпечатъци, лицево разпознаване)
      - Двустепенна верификация (2FA)

2. Авторизация (Authorization)

   - Авторизацията е процесът на предоставяне на достъп до ресурси и данни, след като потребителят вече е бил аутентифициран.
     
   - Това определя какво може и какво не може да прави потребителят в системата.
     
   - Авторизацията се извършва след успешна аутентификация.
     
   - Включва следните стъпки:

      - Проверка на правата - Системата проверява какви права и привилегии има потребителят и какви ресурси може да достъпи.
      - Прилагане на правата - Системата предоставя или отказва достъп до ресурсите въз основа на зададените права.
        
   - Примери за авторизация включват:

      - Достъп до определени файлове или папки
      - Изпълнение на специфични команди или функции
      - Достъп до определени части на приложението

3. ASP.NET Identity

   -  ASP.NET Core Identity е система за удостоверяване и авторизация, която предоставя инфраструктура за управление на потребители, роли и права в уеб приложенията, базирани на ASP.NET Core.
  
   -  Удостоверяване(Authentication) и Авторизация (Authorization).
  
   -  Поддържа ASP.NET Core MVC, Razor Pages, Web API (с JWT токени), SignalR и други.
  
   -  Позволява създаване, управление и поддръжка на потребители, включително техните профили и управлението на роли и права на достъп за различни потребителски групи.

   - Вграден механизъм за управление на съгласие за използване на бисквитки, съобразен с изискванията на GDPR (Общ регламент за защита на данните).
  
   - Поддържа интеграция с външни доставчици за вход като Facebook, Google, Twitter и други, което улеснява потребителите да се логват с вече съществуващи акаунти.
  
   - Позволява съхраняване на потребителските данни в различни типове бази данни, включително SQL Server, Azure, Active Directory, Windows Users и други.
  
   - Required NuGet package
     
      - Microsoft.AspNetCore.Identity.EntityFrameworkCore

   - Password settings – can be defined in Program.cs
     
      ```csharp

         builder.Services.AddDefaultIdentity<IdentityUser>(options =>
         {
            // Password, lockout, emails, etc.
            options.SignIn.RequireConfirmedAccount = false;
            options.Password.RequireDigit = false;
         })
         .AddEntityFrameworkStores<ApplicationDbContext>();

         

   - Use the [Authorize] and [AllowAnonymous] attributes to configure Authorized / Anonymous access for Controller / Action

      ```csharp
      
            var currentUser = await userManager.GetUserAsync(this.User);
            var currentUserUsername = await userManager.GetUserNameAsync(currentUser);
            var currentUserId = await userManager.GetUserIdAsync(currentUser);
            var roles = await userManager.GetRolesAsync(currentUser);

         

--------------------------------------------------------------------------------------------------------------------------------------------------

 <br/>
 
## Routing and Binding, Views, DI and Services

1. Маршрутизация (Routing)

   - процесът на съпоставяне на URL адреси към определени действия в контролерите на ASP.NET Core MVC приложението.
  
   - Конвенционална маршрутизация (Conventional Routing)
     
        - В Startup.cs файлът на приложението (по-конкретно в метода Configure), маршрутите обикновено се дефинират чрез метода UseEndpoints
          
          ```csharp
             endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
                

   - Атрибутна маршрутизация (Attribute Routing):ю
     
        - Позволява задаването на маршрути директно в контролерите и техните действия с помощта на атрибути.
  
          ```csharp
             [Route("products/{id}")]
               public IActionResult GetProduct(int id) {
                   // Логика за връщане на продукт по ID
               }
          
             
   - Статични файлове и маршрутизация

     - За достъп до статични файлове (като CSS, изображения, JavaScript) се използва UseStaticFiles
  
        ```c#
             app.UseStaticFiles(new StaticFileOptions {
                   FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "MyStaticFiles")),
                   RequestPath = "/StaticFiles"
               });
         ```

     
3. Model Binding Overview
   
   - Model Binding в ASP.NET е процес, който автоматично свързва данните от HTTP заявките (като тези от формуляри, URL параметри или query strings) с параметрите на метода в контролера или със свойствата на модела (обект).
  
   - Attributes (Атрибути)
     
      - [BindRequired]
         - Добавя грешка в състоянието на модела, ако свързването не може да се осъществи.

      - [BindNever]
         - Указва на свързвача на модела никога да не свързва този параметър.

      - [From{source}]
         - Използва се за указване на точния източник за свързване.
           
      - [FromServices]
         - Използва dependency injection, за да свърже параметри от услуги.

      - [FromBody]
         - Използва конфигурирани форматъри за свързване на данни от тялото на заявката.

      - [ModelBinder]
         - Използва се за презаписване на стандартния свързващ механизъм, източника на свързване и името.

   - За да създадеш Model Binding, трябва да направиш два класа: един, който ще служи като свързвач (Binder), и един, който ще осигури този свързвач (BindingProvider).

4. Model Validation

   - процес, при който се проверява дали данните, подадени от потребителя или получени от външни източници, отговарят на определени правила и условия, преди да бъдат използвани в приложението. 

   - Валидирането на модел се извършва след свързването на модел
       - Първо данните от заявката се свързват с модела чрез процеса на Model Binding. След това тези данни се валидират, за да се увери, че отговарят на необходимите условия.
   
   - Два типа валидация:

       - Client-side (Клиентска валидация):
         
         - Валидацията се извършва на клиента (в браузъра) преди данните да бъдат изпратени на сървъра. Това предоставя на потребителя незабавна обратна връзка за грешките, което подобрява потребителското изживяване.

       - Server-side (Сървърна валидация):
         
         - Валидацията се извършва на сървъра, когато данните се изпратят от клиента. Това гарантира, че данните са валидни, независимо от действията на потребителя. Сървърната валидация е задължителна, защото клиентската валидация може да бъде заобиколена.
        
  - Свойството ModelState.IsValid показва дали валидацията на модела е успешна
    
      - В контролера можеш да провериш ModelState.IsValid, за да видиш дали моделът е преминал успешно валидацията. Ако не е, можеш да върнеш грешки или да покажеш съобщения на потребителя.
   
  - Можете да създадете собствени атрибути за валидация:

       ```csharp
             public class IsBeforeAttribute : ValidationAttribute {
             private readonly DateTime _date;
         
             public IsBeforeAttribute(string date) {
                 _date = DateTime.Parse(date);
             }
         
             protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
                 var dateValue = (DateTime)value;
                 if (dateValue >= _date) {
                     return new ValidationResult($"Date must be before {_date.ToShortDateString()}");
                 }
                 return ValidationResult.Success;
             }
         }
         
         public class UserModel {
             [IsBefore("01/01/2000", ErrorMessage = "Birth date must be before January 1st, 2000")]
             public DateTime BirthDate { get; set; }
         }
          
   - Интерфейс IValidatableObject

        - Ако валидирането изисква сложна логика, която не може да бъде уловена само с атрибути, можете да имплементирате интерфейса IValidatableObject в модела.

       ```csharp
          public class RegisterUserModel : IValidatableObject {
                public string Password { get; set; }
                public string ConfirmPassword { get; set; }
            
                public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) {
                    if (Password != ConfirmPassword) {
                        yield return new ValidationResult("Passwords do not match");
                    }
                }
            }
       

5. Работа с файлове

   - Качване на файлове (Uploading Files)
     
      - ASP.NET Core поддържа качването на файлове чрез обвързване на модели, като предоставя възможност за качване на единични или множество файлове.
    
      - За да качите файлове чрез HTML формуляр, трябва да зададете атрибута enctype="multipart/form-data"
            <form method="post" enctype="multipart/form-data" asp-controller="Files" asp-action="Upload">
                <input type="file" name="file">
                <button type="submit">Upload</button>
            </form>

      - Ако искате да поддържате качване на множество файлове, добавете атрибута multiple към полето за качване: <form method="post" enctype="multipart/form-data" asp-controller="Files" asp-action="Upload">  <input type="file" name="files" multiple>

   - В контролера, файловете могат да се приемат като параметри от типа IFormFile за единичен файл или IEnumerable<IFormFile> за множество файлове.

      - public async Task<IActionResult> Upload(List<IFormFile> files)
    
6. Layout and Special View Files

   - Layout файлове
  
      - Лейаутите в ASP.NET Core са подобни на основен шаблон или мастър страница, която служи като основа за всички останали изгледи в приложението. Той определя общата структура на уеб страниците – например, общо заглавие, менюта, футъри и други елементи, които се повтарят на много страници.
    
      - обикновено се намират в директорията Views/Shared
    
      - @RenderBody(): Това е специален метод в лейаут файловете, който указва къде ще бъде вмъкнато съдържанието на конкретния изглед. Всички страници, които използват този лейаут, ще имат своето основно съдържание вмъкнато на мястото на @RenderBody().

      - Всеки изглед може да посочи кой лейаут да използва чрез задаване на свойството Layout в началото на файла:
    
              @{
                   Layout = "_Layout";
              }

           - Ако не бъде указано нищо, по подразбиране ще се използва лейаутът, зададен в _ViewStart.cshtml.
       
       - Sections в лейаута
    
            - Секциите са области, които могат да бъдат запълнени от конкретен изглед, използващ този лейаут.
        
            - Те се дефинират с @RenderSection() в лейаут файла и могат да бъдат задължителни или опционални.
        
            -  @RenderSection("Scripts", required: false) -> в лейаута
        
            -  @section Scripts {
                   <script src="~/js/specific-script.js"></script>
                           } -> в изгледа

   - Специални изгледи (Special View Files)
  
        - _ViewStart.cshtml
    
             - Файлът _ViewStart.cshtml се намира обикновено в директорията Views и се изпълнява преди всеки изглед. Той се използва за задаване на общи настройки за всички изгледи в дадена папка или в цялото приложение.
         
             - Например, можете да зададете общия лейаут за всички изгледи в _ViewStart.cshtml:
         
                     @{
                         Layout = "_Layout";
                        } (Всеки изглед в тази папка автоматично ще използва _Layout.cshtml, освен ако не бъде указано друго.)

       - _ViewImports.cshtml

            - Файлът _ViewImports.cshtml също се намира в директорията Views и служи за импорт на общи namespaces, tag helpers и други настройки за всички изгледи.

       - _ValidationScriptsPartial.cshtml

           - Обикновено се намира в папката Views/Shared.

           - Файлът _ValidationScriptsPartial.cshtml е частичен изглед (partial view) в ASP.NET Core, който съдържа JavaScript кодове, свързани с клиентската валидация на формуляри. Този файл обикновено се използва за добавяне на скриптове за валидиране към формулярите в уеб приложението, без да е необходимо да ги добавяте ръчно във всеки изглед.

            - Често _ValidationScriptsPartial.cshtml се включва в секция Scripts на изгледите, за да се осигури, че скриптовете за валидация са заредени, когато страницата се рендира.

                       @section Scripts {
                                   <partial name="_ValidationScriptsPartial" />
                                }

            - asp-for и asp-validation-for таг хелпъри автоматично генерират HTML код, който включва правилните атрибути за валидация.

                       <label asp-for="Name"></label>
                       <input asp-for="Name" />
                       <span asp-validation-for="Name"></span>

   - View Components
  
        - мощна функция в ASP.NET Core, която позволява създаването на многократно използваеми части от потребителския интерфейс (UI), които включват както изгледи, така и бизнес логика. Те са подобни на частичните изгледи, но с повече възможности и по-добра изолация на кода и логиката.
    
        - състоят се от две части:

            - Клас: Класът, който съдържа бизнес логиката и евентуално обработва данни.
    
                 - Класът за View Component обикновено наследява от ViewComponent и има метод, който рендира компонента. Този метод обикновено се нарича InvokeAsync, ако компонентът е асинхронен, или Invoke, ако е синхронен.
                
            - Изглед: Изгледът (view), който рендира HTML-а за компонента.
              
                 - Изгледът на компонента обикновено се поставя в директория с име, което съвпада с името на компонента, в папката Views/Shared/Components. Изгледът трябва да бъде именуван като Default.cshtml.

            - @await Component.InvokeAsync("RecentPosts", new { count = 5 }) -> извикване
         
              
--------------------------------------------------------------------------------------------------------------------------------------------------

 <br/>
 
## Application Flow, Filters & Middleware

1. Application Flow

   - описва последователността от стъпки, през които преминава всяка HTTP заявка в уеб приложение, за да се обработи и да се върне отговор
  
   - В ASP.NET Core това е организирано чрез request pipeline, който включва различни компоненти, като middleware, филтри и контролери.
      - Всеки от тези компоненти може да модифицира заявката или отговора и да реши дали да я предаде на следващия компонент в request pipeline-a.

   - Основни етапи в Application Flow:
  
      - Initial Configuration
        - Приложението се настройва при стартирането му чрез конфигурационни файлове като appsettings.json и чрез код в Program.cs файла.
         
      - Middleware Pipeline
         - Middleware са компоненти, които обработват заявките и отговорите. Всеки middleware може да извършва работа преди и след следващия middleware в request pipeline-a.

      - Routing (Маршрутизиране)
         - След преминаване през middleware pipeline-a, заявката се насочва към конкретен контролер и действие в зависимост от пътя и HTTP метода.

      - Controller and Action Execution
         - Контролерът приема заявката и изпълнява съответното действие. Това е мястото, където се обработва бизнес логиката и се подготвя отговорът.

      - Filters
         - Филтрите позволяват изпълнение на код преди или след определени етапи на заявката. Има различни типове филтри: за авторизация, за ресурси, за действия, за резултати и за изключения.

      - Result Execution
         - След като действието е изпълнено, резултатът (напр. HTML страница, JSON данни и т.н.) се обработва и се връща на клиента. Тук могат да се приложат филтри за резултати, които да модифицират отговора преди изпращането му.

2. Разширяемост и персонализация в ASP.NET Core

   - Environments
     
      - Development (Разработка) – Използва се по време на разработка, където нуждата от повече информация за грешки и отстраняване на проблеми е най-голяма.
        
      - Staging (Тестване/Преходна среда) – Използва се за тестване на приложението в среда, която наподобява производствената, но все още не е на живо.
        
      - Production (Производствена среда) – Използва се, когато приложението е достъпно за крайни потребители. Тук акцентът е върху стабилност, сигурност и производителност.

      - Средата се задава чрез променливата на средата ASPNETCORE_ENVIRONMENT. Тази променлива може да се зададе на ниво операционна система или в конфигурационни файлове като launchSettings.json.

       ```csharp
       
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else if (app.Environment.IsStaging())
            {
                // Настройки специфични за Staging
                app.UseExceptionHandler("/Error");
            }
            else if (app.Environment.IsProduction())
            {
                // Настройки специфични за Production
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }
       
             

3. Middleware

   - Това е софтуерен компонент, който се изпълнява при всяка HTTP заявка и отговор в рамките на уеб приложението.
  
   - Когато уеб сървърът получи HTTP заявка, тя преминава през поредица от middleware компоненти, наречена middleware pipeline. Всеки middleware в този pipeline може:

      - Да обработи заявката и да върне отговор.
        
      - Да изпълни определена логика и да предаде заявката към следващия middleware.
        
      - Да изпълни допълнителна логика след завършването на обработката от следващите middleware-и (например логване).
    
   - Middleware компонентите се изпълняват последователно, в реда, в който са добавени в тръбопровода.
  
   - Всеки middleware може да реши дали да предаде заявката на следващия компонент или да прекрати тръбопровода и да върне отговор директно.
  
   - В ASP.NET Core middleware се добавят в Program.cs файла чрез методи като Use, Run, и Map.

      - Use: Използва се за добавяне на middleware компоненти, които могат да предават заявката към следващия middleware.
        
      - Run: Използва се за добавяне на middleware, който завършва обработката на заявката и не предава контрола по-нататък.
        
      - Map: Използва се за разклоняване на тръбопровода въз основа на пътя на заявката 

   - await next.Invoke() е ключов момент, който позволява на заявката да продължи по pipeline-a.
  
4. Error Handling

   - Обработката на грешки включва различни подходи и инструменти, за да се гарантира, че грешките се управляват правилно в различни среди.

   - Developer Exception Page (Страница за грешки за разработчици)
  
      - app.UseDeveloperExceptionPage();
  
      - предоставя детайлна информация за грешки
    
      - подходяща за използване по време на разработка (Development среда)
     
   - Exception Handler (Глобален обработчик на изключения)
  
      - app.UseExceptionHandler("/Home/Error");
             app.UseHsts();

      - улавя всички неуловени изключения в приложението и ги насочва към определен маршрут или метод за обработка
    
      - подходящо за производствена среда, където подробностите за грешките не трябва да се показват на крайните потребители. Вместо това, те могат да бъдат насочвани към специална страница за грешки
     
   - Status Code Pages (Страници за статус кодове)
     
      - app.UseStatusCodePages(); ->  показва обикновени текстови съобщения за стандартни HTTP статус кодове
    
      - app.UseStatusCodePagesWithReExecute("/Home/Error/{0}"); -> грешките ще бъдат пренасочени към метода Error, като статус кодът ще бъде предаден като параметър
        
      - позволява на приложението да върне страници за определени HTTP статус кодове, като 404 (Not Found) или 500 (Internal Server Error)
   
   - Custom Error Pages (Персонализирани страници за грешки)
     
      - app.UseExceptionHandler("/Error");
             app.UseStatusCodePagesWithRedirects("/Error/{0}");
      
      - позволяват на разработчиците да създават собствени страници за обработка на грешки, които да показват по-приятелски и потребителски ориентирани съобщения
    
      - когато искаш да контролираш изцяло какви съобщения виждат потребителите при грешка
     
   - Exception Filters (Филтри за изключения)
     
      - филтри, които се прилагат на ниво контролер или действие и позволяват уловянето на изключения специфично за даден контролер или метод
    
      - когато искаш да уловиш и обработиш специфични изключения на ниво контролер или действие
  
     ```csharp
                    public class CustomExceptionFilter : IExceptionFilter
            {
                public void OnException(ExceptionContext context)
                {
                    // Логика за обработка на изключението
                }
            }


              /////

                             [ServiceFilter(typeof(CustomExceptionFilter))]
               public class HomeController : Controller
               {
                   // Методи на контролера
               }

     
   - Този филтър се прилага на ниво контролер и улавя всички изключения, хвърлени в рамките на този контролер или неговите действия

5. Filters

   - механизми, които позволяват изпълнение на код на различни етапи от обработката на заявки
       
   - те са част от MVC слоя и не трябва да се бъркат с middleware, който работи на ниво ASP.NET Core
  
   - Разлика между Филтри и Middleware
  
     - Middleware:

       - Middleware работи на ниво на ASP.NET Core и се прилага глобално за целия HTTP пайплайн на приложението.
              
       - Middleware обработва HTTP заявки и отговори преди те да достигнат до MVC частта на приложението.
           
       - Регистрира се в Startup.Configure метода.
              
     - Филтри:

       - Филтрите работят на ниво ASP.NET Core MVC и са част от MVC слоя. Те се прилагат за конкретни контролери или действия.
              
       - Регистрират се в Startup.ConfigureServices, или се прилагат директно към контролери и действия чрез атрибути.

   - Видове Филтри и техните роли:
  
     - Authorization Filters
    
        - Изпълняват се първи и проверяват дали клиентът е авторизиран да получи достъп до исканата функционалност.
      
     - Resource Filters
       
        - Изпълняват се веднага след авторизацията и могат да изпълняват код преди и след останалата част от обработката на заявката.
      
        - След филтрите за авторизация, но преди действията и резултатите.
      
     - Action Filters
       
        - Изпълняват се непосредствено преди и след извикването на метод на действие.
      
        - Примерна употреба: Логиране, валидиране на входни данни, модифициране на резултати.
      
     - Exception Filters
    
        - Прилагат глобални политики за необработени грешки, които възникват в метода на действие.
      
     - Result Filters
    
        - Изпълняват се непосредствено преди и след изпълнението на индивидуални резултати от действията.
      
        - Примерна употреба: Модифициране на изходни данни преди тяхното изпращане на клиента.

   - Синхронни и Асинхронни Филтри
  
      - Синхронни Филтри:
        
         - Изпълняват се в основния поток.
          
         - Не използват асинхронни операции.
       
         - Пример: Логиране, проверка на входни данни, валидиране на входни параметри.

      - Асинхронни Филтри:

         - Позволяват изпълнение на асинхронни операции, без да блокират основния поток.
           
         - Използват асинхронни версии на филтровите интерфейси.
       
         - Пример: Извикване на асинхронни методи за достъп до бази данни или уеб услуги, обработка на заявки, които могат да отнемат време.
           
   - Filters are added globally in the MvcOption.Services
     
        - Will be applied to all Controllers and Actions

          ```c#

                builder.Services.AddMvc(options => {
                     options.Filters.Add(new SampleActionFilter()); // instant
                     options.Filters.Add(typeof(SampleActionFilter)); // by type
                     ...
                });
          ```


    - ServiceFilterAttribute

        - ServiceFilterAttribute се използва, когато искате да използвате филтри, които са регистрирани като услуги в Dependency Injection (DI) контейнера.
     
        - Първо, трябва да регистрирате филтъра като услуга в DI контейнера.

           ```c#
               public void ConfigureServices(IServiceCollection services)
               {
                   services.AddScoped<MyServiceFilter>(); // Регистрация на филтъра
               }
             ```

  
        - След това използвате ServiceFilterAttribute, за да кажете на MVC да използва този филтър за конкретен контролер или действие.
  
           ```csharp
               [ServiceFilter(typeof(MyServiceFilter))]
               public class MyController : Controller
               {
                   public IActionResult Index()
                   {
                       return View();
                   }
               }
                  ```
             
     - TypeFilterAttribute

        - TypeFilterAttribute се използва, когато искате да създадете филтър с параметри, които не са регистрирани в DI контейнера. Можете да зададете какви стойности да се предадат на филтъра, когато се създава.
      
        - Създавате филтър, който може да приема параметри чрез конструктора си.

          ```c#
          [TypeFilter(typeof(MyTypeFilter), Arguments = new object[] { "MyValue" })]
            public class MyController : Controller
            {
                public IActionResult Index()
                {
                    return View();
                }
            }
          ```



--------------------------------------------------------------------------------------------------------------------------------------------------

 <br/>
 
## Web API

1. JSON (JavaScript Object Notation)

   - JSON е текстов формат за предаване на структурирани данни, базиран на JavaScript синтаксис
  
   - Данните в JSON са организирани в ключ-стойност двойки или масиви. Това го прави подходящ за описване на обекти и масиви от данни.
  

     {
        "firstName": "Peter",
        "age": 23,
        "hasDriverLicense": true,
        "courses": ["C#", "JS", "ASP.NET"],
        "date": "2012-04-23T18:25:43.511Z"
     }

   - JSON поддържа различни типове данни като числа, булеви стойности, низове, масиви и обекти.
  
   -  JSON е един от най-популярните формати за предаване на данни между клиент (браузър) и сървър в уеб приложения.
  
   -  В сравнение с XML, JSON е по-компактен и по-бърз за парсиране, което го прави по-подходящ за уеб приложения, където скоростта и ефективността са важни.
  
   -  MIME тип: application/json

   - Разширение на файла: .json

2. XML (Extensible Markup Language)

   - XML е формат за маркиране на документи, който дефинира правила за кодиране на данни в структуриран текст. Той е проектиран за пренос на данни и се използва широко за конфигурация и описване на документи.
  
   - XML използва тагове за обозначаване на различни елементи в документа. Всеки таг има начало и край, които обграждат съдържанието му.
  
     <records>
         <record id="1">
             <name>Ivo</name>
             <email>ivo@softuni.bg</email>
             <company>Software University</company>
         </record>
         <record id="2">
             <name>Niki</name>
             <email>admin@Nikolay.it</email>
             <company>ZenCodeo</company>
         </record>
      </records>

   - XML е широко използван в конфигурационни файлове на приложения (напр. в .NET), за съхранение на данни (напр. в Office документи) и в уеб услуги, базирани на SOAP протокол.
  
   - XML е независим от платформа и език, което го прави подходящ за използване в различни системи и приложения.
  
   - MIME тип: application/xml, text/xml
     
   - Разширение на файла: .xml

3. JavaScript

   - JavaScript е един от основните езици за програмиране, използвани в уеб разработката. Той е динамичен, обектно-ориентиран език, който играе ключова роля в създаването на интерактивни и динамични уеб страници. Наред с HTML и CSS, JavaScript е една от основните технологии, които оформят съвременния уеб.
  
   - JavaScript е скриптов език, което означава, че кодът му се изпълнява директно от браузъра, без нужда от компилация. Това позволява бързо разработване и тестване на уеб приложения.
  
   - JavaScript позволява обработка на събития като натискане на бутон, движение на мишката, въвеждане на текст и други потребителски действия. Това го прави идеален за създаване на интерактивни интерфейси.

4. DOM

   - DOM (Document Object Model) е програмният интерфейс (API), който представлява структурата на уеб документа, например HTML или XML документ.
  
   - DOM представя HTML документа като дърво от обекти. Всеки елемент от HTML страницата (текст, елементи, атрибути и т.н.) е представен като възел (node) в това дърво.

   - В корена на това дърво стои обектът document, който представлява цялата HTML страница.
  
   - Чрез DOM програмистите могат да получат достъп до всяка част от HTML документа и да я променят.
  
      let title = document.title; // Получаване на заглавието на страницата

      let header = document.getElementById("header"); // Избор на елемент по ID

      let newElement = document.createElement("p"); // Създаване на нов елемент
      newElement.textContent = "Това е нов параграф.";
      document.body.appendChild(newElement); // Добавяне на новия елемент към тялото на документа

      header.addEventListener("click", function() {
          alert("Заглавието беше кликнато!");
      });

6. AJAX (Asynchronous JavaScript and XML)

   - набор от техники за уеб разработка, които позволяват създаването на асинхронни уеб приложения.
  
   - AJAX не е самостоятелен програмен език, а по-скоро техника или подход, който използва съществуващи технологии, като JavaScript и XML, за да изпълнява асинхронни HTTP заявки.

   - Основният инструмент, който AJAX използва за изпращане на заявки към сървъра, е обектът XMLHttpRequest. Той позволява на JavaScript да изпраща и получава данни чрез HTTP протокола.
  
   - Докато AJAX често се свързва с XML, в модерните уеб приложения JSON се използва много по-често за обмен на данни, защото е по-лесен за работа и по-бърз за парсиране.
  
   - Примерен работен процес на AJAX:
     
     - Инициализация на заявката:
       
         - Потребителят извършва някакво действие (например натиска бутон), което задейства AJAX заявка.
           
     - Изпращане на заявката:
   
         - Обектът XMLHttpRequest се използва за изпращане на заявката към сървъра.
           
     - Обработка на отговора:
   
         - Когато сървърът върне отговор, JavaScript го обработва и взема необходимите действия, като например актуализиране на част от уеб страницата.
           
     - Актуализиране на интерфейса:
   
         - Без да се презарежда цялата страница, част от съдържанието ѝ се актуализира в съответствие с получените данни.

7. jQuery

  - една от най-популярните и широко използвани JavaScript библиотеки, създадена с цел да опрости манипулацията на HTML документи, управлението на събития, анимации и AJAX взаимодействия.

  - jQuery предоставя мощни и лесни за използване методи за работа с DOM (Document Object Model). С jQuery можете лесно да селектирате елементи, да ги променяте, да добавяте или премахвате елементи и да манипулирате техните атрибути и стилове.

    // Избиране на всички елементи с клас "menu-item" и промяна на техния фон
    
      $('.menu-item').css('background', 'blue');

    // Добавяне на събитие за клик върху бутон с ID "myButton"
    
      $('#myButton').on('click', function() {
          alert('Бутонът беше натиснат!');
      });

    // Скриване на елемент с ID "myDiv" с избледняване за 400 милисекунди

      $('#myDiv').fadeOut(400);

   - включваме чрез: <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script> в <head>

8. jQuery AJAX

   - jQuery AJAX е мощен инструмент, който значително опростява извършването на AJAX (Asynchronous JavaScript and XML) заявки.
     
   - Това позволява на разработчиците да взаимодействат със сървъра без да се презарежда цялата уеб страница.
  
   - jQuery AJAX методите предоставят функции за обработка на отговорите, когато заявката е успешна (.done()) или е неуспешна (.fail()).
  
   - $.ajax(): Това е основният метод за изпълнение на AJAX заявка. Той предоставя голяма гъвкавост и позволява конфигурирането на множество параметри, като тип на заявката (GET, POST и т.н.), URL адрес, данни за изпращане и функции за обработка на отговорите.
  
         $.ajax({
           method: 'GET',
           url: 'https://example.com/api/data',
           data: { id: '42' }
         })
         .done(function(response) {
             alert('Success: ' + response);
         })
         .fail(function(jqXHR, textStatus) {
             alert('Request failed: ' + textStatus);
         });

   - $.get() и $.post(): Това са съкратени методи за изпращане на GET и POST заявки.
    
       $.get('https://example.com/api/data', { id: '42' })
              .done(function(response) {
                console.log(response);
       });

       $.post('https://example.com/api/data', { id: '42', name: 'John' })
              .done(function(response) {
               console.log(response);
       });

   - $.getJSON(): Метод за изпращане на GET заявка и автоматично парсване на JSON отговора.

      $.getJSON('https://example.com/api/data', function(response) {
          console.log(response);
      });

9. Web Services

    - Уеб услугата е специфичен вид API, който се осъществява чрез интернет (или друга мрежа) и използва стандартни протоколи като HTTP, SOAP, или REST.
  
    - Уеб услугите позволяват различни системи и приложения да взаимодействат независимо от техните вътрешни технологии, благодарение на използването на стандартни протоколи като HTTP и формати като XML и JSON.
  
    - Уеб услугите обменят съобщения между клиент и сървър. Съобщенията могат да съдържат заявки за информация или операции, както и отговори на тези заявки.
  
    - REST (Representational State Transfer)
      
         - REST е архитектурен стил, който използва HTTP протокола и е много по-лек от SOAP.
         
         - RESTful уеб услугите работят с ресурси, които могат да бъдат достъпвани чрез стандартни HTTP методи като GET, POST, PUT и DELETE.
         
         - Те обикновено използват JSON или XML за обмен на данни.

         - В RESTful услугите, всеки ресурс има уникален URI, чрез който клиентите могат да го достъпват.

          
--------------------------------------------------------------------------------------------------------------------------------------------------

 <br/>
 
## Web Application Security

1. Често срещани проблеми със сигурността

   - SQL инжекция (SQL Injection)
     
   - Междусайтови скриптове (Cross-Site Scripting - XSS)
     
   - Манипулация на параметри (Parameter Tampering)

   - Междусайтово искане за фалшифициране (Cross-Site Request Forgery - CSRF)

   - Атаки като DoS, DDoS, и Brute Force

   - Проблеми със сигурността в друг софтуер, който се използва
  
2. Cross-Site Scripting (XSS)

   - вид атака срещу уеб приложения, при която нападателите инжектират зловредни скриптове в съдържание, което след това се изпълнява от браузъра на потребителя.
     
   - Тези атаки са опасни, защото позволяват на злонамерени лица да манипулират взаимодействията на потребителя със сайта и да получат достъп до чувствителни данни.
  
   - Атаките XSS възникват, когато уеб приложение приема и отразява потребителски вход (напр. коментари, търсения) без адекватно валидиране или кодиране. Това позволява на нападателя да инжектира скрипт (обикновено JavaScript) в отговора на сървъра. Когато друг потребител зареди страница с този зловреден код, скриптът се изпълнява в контекста на неговата сесия.
  
   - Основни видове XSS атаки
  
      - Stored XSS (Съхранен XSS)
    
           - Зловредният скрипт се съхранява на сървъра, например в база данни, и се изпълнява всеки път, когато потребителят зареди засегнатата страница.
    
      - Reflected XSS (Отразен XSS)
    
      - DOM-based XSS (XSS, базиран на DOM)

   - Опасности от XSS
  
      - Кражба на бисквитки: Нападателите могат да откраднат сесийните бисквитки на потребителя, което може да доведе до неоторизиран достъп до акаунти.
        
      - Изпълнение на зловредни действия: Скриптовете могат да изпълняват действия от името на потребителя, като промяна на настройки, изпращане на съобщения или извършване на транзакции.
        
      - Кражба на чувствителна информация: Зловредният код може да получи достъп до съхранени пароли, лични данни и друга чувствителна информация.

   - Защита срещу XSS
  
      - Кодиране на изхода: Винаги кодирайте данните, които се показват на страницата, особено ако идват от потребителски вход.
        
      - Валидиране и почистване на входа: Проверявайте и филтрирайте всички входни данни, за да предотвратите инжектиране на зловреден код.
        
      - Използване на защитни библиотеки: В много платформи и фреймуъркове като ASP.NET Core се предлагат вградени защити срещу XSS, като автоматично кодиране на изхода и използване на специализирани библиотеки като HtmlSanitizer.

      - Избягване на използване на опасни функции: Не използвайте функции като eval() в JavaScript, които могат лесно да доведат до XSS.

3. SQL инжекция (SQL Injection)

    - позволява на нападателите да вмъкват зловреден SQL код в заявките към базата данни на приложението, като по този начин получават неоторизиран достъп до данни, променят или изтриват информация
  
    - пример:
      
         - SELECT * FROM Users WHERE username = 'user' AND password = 'pass';
           
         - SELECT * FROM Users WHERE username = 'admin' --' AND password = 'anything'; --> ще се логнем като админ без парола
  
    - Как да се защитим от SQL инжекция
  
       - Използване на параметризирани заявки: Вместо да включвате входни данни директно в SQL заявките, използвайте параметризирани заявки, които гарантират, че входните данни ще се третират като данни, а не като част от самата SQL заявка. (SELECT * FROM Users WHERE username = @username AND password = @password;)
     
       - Използване на ORM (Object-Relational Mapping) инструменти: Те автоматично обработват заявките и предпазват от SQL инжекции.

       - Санитизация и валидиране на входни данни.
     
       - Ограничаване на правата на базата данни: Уверете се, че потребителите на базата данни имат минимално необходими права. Например, приложението не трябва да използва администраторски акаунт за връзка с базата данни.
     
       - Използване на защитни стени и системи за откриване на атаки: Те могат да помогнат за откриване и блокиране на опити за SQL инжекция.
     
4. Cross-Site Request Forgery

   - вид уеб атака, при която нападателят принуждава потребител да изпълни нежелани действия в уеб приложение, в което е автентициран. Това се осъществява чрез използване на сесийни бисквитки или други механизми за удостоверяване, които потребителят вече е предоставил на уеб приложението.
  
   - CSRF атаките се основават на факта, че уеб браузърите автоматично включват всички подходящи бисквитки (включително сесийните) с всяка заявка, която се прави към уеб приложение. Нападателят създава злонамерена уеб страница или скрипт, който изпраща заявка към уязвимото уеб приложение от името на потребителя, без той да подозира.
  
   - Защита срещу CSRF
  
        - Anti-CSRF токени: Това е най-ефективният метод за защита. Във всяка чувствителна операция (напр. прехвърляне на пари, промяна на парола) се включва скрит токен, генериран на сървъра. Този токен трябва да се изпрати заедно със заявката, и ако той липсва или не съвпада с този на сървъра, заявката се отхвърля.
    
        - Включване на допълнително удостоверяване: За критични операции, изисквайте повторно удостоверяване на потребителя, като например въвеждане на парола или допълнителен PIN.
    
        - Използване на SameSite флаг за бисквитките: Този флаг ограничава бисквитките да бъдат изпращани само с заявки, инициирани от същия сайт, което може да предотврати CSRF атаки.
    
        - Използване на CORS (Cross-Origin Resource Sharing): Позволява на сървърите да определят кои външни сайтове могат да правят заявки към тях и какви видове заявки са разрешени.

        - Избягване на автоматични действия: Препоръчително е да избягвате автоматични действия като автоматично изпращане на форми или използване на GET заявки за изпълнение на действия, които променят състоянието на данни.
    
5. Parameter Tampering

   - Parameter Tampering е вид атака срещу уеб приложения, при която нападателят манипулира параметри, които се изпращат от клиента към сървъра, с цел да промени поведението на приложението или да получи неоторизиран достъп до данни или функционалности. Това може да включва промяна на URL параметри, форми, куки (cookies), или дори тела на заявки (request bodies).

   - Промяна на URL параметри: Да предположим, че потребителят преглежда информация за поръчка чрез URL като: https://example.com/order?id=1234
  
      - Ако нападателят промени id параметъра на друга стойност, например: https://example.com/order?id=5678, и сървърът не проверява дали потребителят има права за достъп до поръчка с ID 5678, нападателят може да получи достъп до информация за поръчки на други потребители.
    
   - Промяна на стойности в HTTP тела: В онлайн магазин, нападателят може да промени цената на даден артикул, като модифицира стойността на параметър в HTTP POST заявката: <input type="hidden" name="price" value="100">

   - Манипулиране на куки (cookies): Куките могат да съдържат информация като сесийни идентификатори или нива на достъп. Ако тези куки не са защитени и нападателят успее да ги промени, може да получи неоторизиран достъп до различни функционалности на приложението.
  
   - Как да се защитим от Parameter Tampering

6. CORS (Cross-Origin Resource Sharing)

   - Browser security prevents a web page from making requests to a domain, different from the one that served the web page (its origin)

   - This restriction is called Same-Origin Policy (SOP)
  
   - Two URLs have the same origin if they have

   - Identical Schemes, Hosts and Ports (RFC 6454)

   - CORS позволява на сървърите да контролират достъпа до своите ресурси, като задават специфични HTTP заглавия, които указват на браузъра дали да разреши достъпа до ресурсите от външни домейни.
  
   - Когато уеб приложение прави заявка към ресурс на различен домейн, браузърът първо изпраща така наречената "preflight" заявка (OPTIONS заявка), за да провери дали сървърът разрешава този тип заявка от външния домейн. Сървърът отговаря със CORS заглавия, които указват дали заявката е разрешена.

          
--------------------------------------------------------------------------------------------------------------------------------------------------

 <br/>
 
## Advanced Identity

1. Пълен контрол върху идентичността в ASP.NET Core

   - Отнася се до възможността за разширяване и персонализиране на стандартното поведение на идентичността, за да отговори на специфичните нужди на приложението.
  
   - Разширяване на IdentityUser
  
        - ASP.NET Core Identity предоставя клас IdentityUser, който представлява потребител. Този клас може да бъде разширен с допълнителни свойства, за да съхранява повече информация за потребителите.
  
          ```c#

            public class ApplicationUser : IdentityUser
            {
                public string FirstName { get; set; }
                public string LastName { get; set; }
            }

          ```
    
     - За да използвате персонализирания потребителски клас, трябва да конфигурирате идентичността в Startup.cs:

          ```c#
               public void ConfigureServices(IServiceCollection services)
               {
                   services.AddDbContext<ApplicationDbContext>(options =>
                       options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
               
                   services.AddIdentity<ApplicationUser, IdentityRole>()
                       .AddEntityFrameworkStores<ApplicationDbContext>()
                       .AddDefaultTokenProviders();
               
                   services.ConfigureApplicationCookie(options =>
                   {
                       options.LoginPath = "/Identity/Account/Login";
                       options.LogoutPath = "/Identity/Account/Logout";
                       options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                   });
               
                   services.AddControllersWithViews();
               }
         ```
          
         - Тук AddIdentity<ApplicationUser, IdentityRole>() указва, че се използва персонализираният клас ApplicationUser, вместо да се използва дефоутното: services.AddDefaultIdentity<IdentityUser>.AddRoles<IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();

   - Можете да конфигурирате пътищата за вход, изход и отказан достъп, като използвате ConfigureApplicationCookie:

        ```c#
         services.ConfigureApplicationCookie(options =>
         {
             options.LoginPath = "/Identity/Account/Login";
             options.LogoutPath = "/Identity/Account/Logout";
             options.AccessDeniedPath = "/Identity/Account/AccessDenied";
         });
        ```

2. Claims

   - Твърденията (Claims) са мощен механизъм за удостоверяване и авторизация, който предоставя информация за потребителя под формата на двойки име-стойност. 

   - В ASP.NET Core твърденията биват използвани за удостоверяване и авторизация чрез политики, които определят правилата за достъп до различни части на приложението.
    
   - Пример: Name: "John Doe"; Role: "Administrator"; EmployeeNumber: "12345"

   - Твърденията могат да бъдат добавени към идентичността на потребителя при влизане в системата. Пример:
  
        ```c#
         var claims = new List<Claim>
         {
             new Claim(ClaimTypes.Name, "John Doe"),
             new Claim(ClaimTypes.Role, "Administrator"),
             new Claim("EmployeeNumber", "12345")
         };
         
         var identity = new ClaimsIdentity(claims, "CustomAuthentication");
         var principal = new ClaimsPrincipal(identity);
         await HttpContext.SignInAsync(principal);
       ```

     - конфигуриране на политика за твърдения:

       ```c#
         services.AddAuthorization(options =>
         {
             options.AddPolicy("EmployeeOnly", policy => policy.RequireClaim("EmployeeNumber"));
         });
         ```

     - Използване на политика в контролер
    
       ```c#
       [Authorize(Policy = "EmployeeOnly")]
       public IActionResult EmployeeDashboard() => View();
       ```

     - Проверки на твърдения могат да бъдат добавени директно към контролери или действия:
    
       ```c#
       [Authorize]
         public IActionResult Admin()
         {
             if (User.HasClaim(c => c.Type == "EmployeeNumber"))
             {
                 ViewBag.Message = "Welcome, employee!";
                 return View();
             }
             return Unauthorized();
         }
         ```

3. Roles

   - Ролите са ключов елемент на управлението на достъпа и авторизацията в ASP.NET Core.
   
   - Те позволяват на разработчиците да определят и контролират достъпа до различни части на приложението въз основа на ролята, която е присвоена на потребителите.
  
   - За да enable-нем RoleManager:

      ```c#
        builder.Services.AddDefaultIdentity<IdentityUser>(…).AddRoles<IdentityRole>();
      ```
     
   - Създаване на роли:
  
     ```c#
        public async Task CreateRoles(IServiceProvider serviceProvider)
         {
             var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
             string[] roleNames = { "Admin", "User", "Manager" };
             IdentityResult roleResult;
         
             foreach (var roleName in roleNames)
             {
                 var roleExist = await roleManager.RoleExistsAsync(roleName);
                 if (!roleExist)
                 {
                     roleResult = await roleManager.CreateAsync(new IdentityRole(roleName));
                 }
             }
         }
     ```

   - Добавяне на потребител към роля:
  
     ```c#
        public async Task<IActionResult> AddUserToRole()
         {
             var user = await userManager.FindByEmailAsync("user@example.com");
             if (user != null)
             {
                 var result = await userManager.AddToRoleAsync(user, "Admin");
                 if (result.Succeeded)
                 {
                     // Потребителят е добавен към ролята "Admin"
                 }
             }
         }
      ```

   - Можете да ограничите достъпа до контролери или действия чрез атрибута [Authorize], като посочите необходимите роли:
  
      ```c#
      [Authorize(Roles = "Admin")]
      public class AdminController : Controller
      {
          public IActionResult Index()
          {
              return View();
          }
      }
      
      [Authorize(Roles = "User,Manager")]
      public class UserController : Controller
      {
          public IActionResult Dashboard()
          {
              return View();
          }
      }
      ```
   
   - Можете да проверите ролята на потребителя програмно в метода на контролера:

     ```c#
      [Authorize]
      public IActionResult Dashboard()
      {
          if (User.IsInRole("Admin"))
          {
              ViewBag.Message = "Welcome, Admin!";
          }
          else if (User.IsInRole("User"))
          {
              ViewBag.Message = "Welcome, User!";
          }
          else
          {
              ViewBag.Message = "Welcome, Guest!";
          }
          return View();
      }
     ```
     
4. Authentication Types in ASP.NET Core

   - Удостоверяването е процесът на проверка на идентичността на потребителите, които се опитват да влязат в системата.

   - Видове аутентикация:
     
      - Удостоверяване с бисквитки (Cookie-based Authentication)
    
         - Най-често използваното удостоверяване в уеб приложенията. Сесийните бисквитки се използват за съхранение на информация за потребителя след като той се е удостоверил.
       
         - Подходящо за класически уеб приложения, където клиентът и сървърът работят в същия домейн.
       
           ```c#
           services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/Account/Login";
                    options.LogoutPath = "/Account/Logout";
                    options.AccessDeniedPath = "/Account/AccessDenied";
                });
            ```

      - Удостоверяване с Windows (Windows Authentication)

          - Използва операционната система за удостоверяване на потребителите. Най-често се използва в корпоративни среди с Active Directory.
       
          - Подходящо за интранет приложения, където клиентите и сървърите са в същия Windows домейн.
       
           ```c#
           services.AddAuthentication(NegotiateDefaults.AuthenticationScheme)
                .AddNegotiate();
           ```

     - Удостоверяване в облака (Cloud-based Authentication)
    
          - Удостоверяването и авторизацията се извършват от външна платформа като Azure AD, OAuth, или OpenID Connect.
      
     - Удостоверяване с JSON Web Tokens (JWT)
    
          - Модерен метод за удостоверяване, който използва JSON Web Tokens за сигурност на информацията. JWT е самостоятелен и се използва често при RESTful API.
      
          - Подходящо за SPA (Single Page Applications) и мобилни приложения, където се изисква сигурност и лекота на използване.
      
     - Социално удостоверяване (Social Authentication)

          - Позволява на потребителите да се удостоверят с използването на своите съществуващи акаунти от социални мрежи като Google, Facebook, Twitter, и Microsoft.
      
          - Подходящо за уеб и мобилни приложения, които искат да улеснят процеса на регистрация и вход за потребителите.
      
             ```c#
             services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = GoogleDefaults.AuthenticationScheme;
            })
            .AddCookie()
            .AddGoogle(googleOptions =>
            {
                googleOptions.ClientId = Configuration["Authentication:Google:ClientId"];
                googleOptions.ClientSecret = Configuration["Authentication:Google:ClientSecret"];
            })
            .AddFacebook(facebookOptions =>
            {
                facebookOptions.AppId = Configuration["Authentication:Facebook:AppId"];
                facebookOptions.AppSecret = Configuration["Authentication:Facebook:AppSecret"];
            });
            ```

5. JSON Web Tokens

   - Компактен, URL-базиран формат за представяне на твърдения между две страни.
     
   - JWT често се използва за удостоверяване и обмен на информация в уеб приложения, особено при създаване на RESTful API.
  
   - It must be stored (in local / session storage, cookies are also an option).
  
   - Аbsolutely secured.
  
   - As any normal auth JWT also has an expiration.

   - Представлява JSON обект, който се състои от три части: заглавие (header), полезен товар (payload) и подпис (signature). Те са разделени с точки и са кодирани в Base64.
  
      - Заглавие (Header): Съдържа информация за алгоритъма за подписване и типа на токена.
    
      - Полезен товар (Payload): Съдържа твърдения (claims), които са изявления за обекта (например потребителски данни).

      - Подпис (Signature): Използва се за проверка на целостта на токена и автентичността на изпращача.
    
   - Конфигуриране на JWT удостоверяване:
  
      - Инсталирайте необходимия пакет за JWT удостоверяване:

         ```c#
           dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
         ```

      - Добавете конфигурация за удостоверяване в метода ConfigureServices в Pragram.cs:
    
        ```c#
        public void ConfigureServices(IServiceCollection services)
         {
             services.AddAuthentication(options =>
             {
                 options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                 options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
             })
             .AddJwtBearer(options =>
             {
                 options.TokenValidationParameters = new TokenValidationParameters
                 {
                     ValidateIssuer = true,
                     ValidateAudience = true,
                     ValidateLifetime = true,
                     ValidateIssuerSigningKey = true,
                     ValidIssuer = Configuration["JWT:ValidIssuer"],
                     ValidAudience = Configuration["JWT:ValidAudience"],
                     IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:Secret"]))
                 };
             });
         
             services.AddControllers();
         }
         ```

          
--------------------------------------------------------------------------------------------------------------------------------------------------

 <br/>
 
## Project Architecture

1. Web vs Desktop vs Mobile vs IoT
        
   - Уеб приложенията предлагат лесна инсталация, употреба и актуализация.
     
   - В повечето случаи, те са предпочитани пред десктоп приложения, тъй като не са обвързани с конкретно устройство.
     
   - Основната разлика между тях е, че уеб приложенията изискват интернет връзка и имат ограничен достъп до системни ресурси.
  
   - Има 2ма участници в web applications - клиент и сървър

  
2. Web Application Designs

   - Уеб приложенията се проектират с два основни подхода:
  
      - Multi-Page application (MPA)
    
         -  При MPA всяка страница или действие, което потребителят извършва, води до ново зареждане на цялата страница от сървъра.
       
         - Съдържанието на страниците се обновява изцяло при всяко презареждане, което може да доведе до по-бавно потребителско преживяване, особено при по-бавни интернет връзки.
       
         - MPA приложенията обикновено са по-добри за SEO, тъй като всяка страница има собствен URL адрес и съдържанието е лесно достъпно за търсачките.

         - Примери за технологии: ASP.NET Core MVC и Razor Pages.
        
      - Single-Page application (SPA)
    
         - При SPA приложението, цялото необходимо съдържание се зарежда веднъж, когато потребителят посети страницата за първи път. След това, само конкретни части от страницата се обновяват динамично без пълно презареждане на страницата.
       
         - Промяната на съдържанието и навигацията се управляват чрез JavaScript, като обикновено се използват технологии като AJAX за асинхронно зареждане на данни.
       
         - Благодарение на динамичното обновяване на съдържанието, SPA приложенията често предлагат по-бързо и по-интерактивно потребителско преживяване.

         - Back-end: ASP.NET Core Web API returning JSON data, Front-end: Angular, React, Vue.js и Blazor.
       
3. Web Application Architectures

   - Монолитни приложения

     - Монолитното приложение е софтуер, в който всички части на приложението (потребителски интерфейс, бизнес логика, база данни и др.) са обединени в една единствена програма или кодова база. Това е като една голяма програма, която съдържа всичко необходимо за функционирането си.
    
     - Монолитната архитектура е подходяща за по-малки приложения или за екипи, които тепърва започват и имат нужда от по-прост и лесен за управление подход. Тя също така може да е добра основа за по-късно разделяне на приложението на по-малки части (микросървиси) при нужда.

   - Service-Oriented Architectures (SOA) (Архитектури ориентирани към услуги)
  
     - Service-Oriented Architecture (SOA) е подход в разработката на софтуер, който структурира приложение като набор от услуги. Всяка услуга е самостоятелен компонент, който изпълнява конкретна функция и може да комуникира с други услуги през мрежата.
    
     - Услугите комуникират помежду си чрез протоколи като SOAP (Simple Object Access Protocol) и XML (eXtensible Markup Language).
    
     - Лесно е да се заменят или обновят отделни услуги без да се засяга цялото приложение.
    
     - Услугите комуникират чрез Enterprise Service Bus (ESB)
    
          - Enterprise Service Bus (ESB) е архитектурен компонент, който служи като посредник между различни услуги в SOA.
      
          - ESB позволява на различните услуги да комуникират помежду си, без да е необходимо да знаят детайлите за другите услуги. Тоест, вместо да се свързват директно помежду си, услугите изпращат и получават съобщения през ESB.
      
          - ESB може да обработва маршрутизацията на съобщения, трансформации на данни и управление на протоколи. Това означава, че ако една услуга очаква данни в определен формат, ESB може да конвертира съобщението от един формат в друг.

     - Всички услуги споделят една и съща база данни
    
     - Услугите в SOA са проектирани да бъдат многократно използвани в различни приложения.

   - Microservices (Микросървизи)
  
     - Микросървизите представляват архитектурен стил за разработка на софтуер, при който приложението е разделено на малки, независими услуги. Всяка услуга изпълнява конкретна функция и комуникира с другите услуги чрез добре дефинирани интерфейси.
    
     - Всяка услуга е малка по размер и изпълнява конкретна функция.
    
     - Микросървизите комуникират помежду си чрез API (Application Programming Interface), обикновено използвайки HTTP/REST или други протоколи за обмен на съобщения (например, gRPC или AMQP).
    
     - Услугите могат да бъдат разгръщани независимо една от друга.
    
     - Повредата в една услуга не влияе върху функционирането на останалите услуги.
    
     - Всяка услуга може да има собствена база данни, което усложнява управлението на данни и транзакции.
    
4. ASP.NET Core MVC vs Razor Pages

   - ASP.NET Core предлага два основни подхода за изграждане на уеб приложения: MVC (Model-View-Controller) и Razor Pages.
  
   - ASP.NET Core MVC
  
     - Model-View-Controller архитектура: Това е архитектурен шаблон, който разделя приложението на три основни компонента:
       
         - Model: Представлява данните и логиката на приложението. Моделите са отговорни за взаимодействието с базата данни и бизнес логиката.
           
         - View: Отговаря за визуализацията на данните. Това е частта от приложението, която потребителят вижда и с която взаимодействува.
           
         - Controller: Управлява логиката на приложението. Контролерът получава вход от потребителя, обработва заявките и решава какви данни да се покажат в изгледа.
           
     - Маршрутизиране: MVC използва маршрутизационни правила за насочване на HTTP заявките към подходящите контролери и действия.
       
     - Поддръжка на сложни сценарии: Подходящ за големи и сложни приложения с множество различни действия и изгледи.
    
   - Razor Pages
     
     - Page-based архитектура: Razor Pages използва базиран на страници подход, където всяка страница представлява самостоятелна единица с логика и изглед.
       
     - Страници: Всяка страница има .cshtml файл (за изгледа) и свързан .cs файл (за модела и логиката).
       
     - По-просто маршрутизиране: Маршрутизацията е по-проста и директна, тъй като всяка страница има свой URL.
       
     - Двупосочно свързване на данни: Поддържа лесно двупосочно свързване на данни и събития.



<br/>

#Plans for ReactJs

## Introduction to React.js

1. React Overview

   - React е JavaScript библиотека за създаване на потребителски интерфейси (UI).
     
   - Позволява ти да създаваш компоненти — малки, многократно използваеми парчета код, които описват как дадена част от интерфейса трябва да изглежда и да се държи.
     
   - React е бърз, ефективен и много популярен за уеб приложения (SPA).
     
   - Използва виртуален DOM за оптимизиране на обновяванията на екрана.


2. JSX Syntax

   - JSX (JavaScript XML) е специален синтаксис, който се използва в React – прилича на HTML, но се пише в JavaScript.
     
   - Той ти позволява да описваш как трябва да изглежда интерфейсът директно в кода, много лесно и четимо.

// с JSX
   ```jsx
      const app = (
        <div>
          <h1>Заглавие</h1>
          <p>Текст</p>
        </div>
      );
   ```

// без JSX
   ```js
      const app = React.createElement(
        'div',
        null,
        React.createElement('h1', null, 'Заглавие'),
        React.createElement('p', null, 'Текст')
      );
   ```

   - Babel: превежда JSX → в React.createElement(...)

3. React Installation

   - npx create-react-app my-app
  
   - cd my-app
  
   - npm start






















         
      
      
       









