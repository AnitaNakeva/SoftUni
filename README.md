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
     
      - База данни – методи EnsureCreated/Deleted, връзка с базата данни
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



