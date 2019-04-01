# seleniumgrid
.NET C# * Selenium WebDriver &amp; Grid * Chrome Browser


PATH : chromeDriver.exe

(CMD)    HUB : java -Dwebdriver.chrome.driver=PATH -jar selenium-server-standalone-3.141.59.jar -role hub -hubConfig hub-conf.json

(CMD) NODE : java -Dwebdriver.chrome.driver=PATH -jar selenium-server-standalone-3.141.59.jar -role node -nodeConfig win-node-conf.json -hub http://localhost:4444/grid/register/

![alt text](https://github.com/oguzhanvrl/seleniumgrid/blob/master/screenshotGRID.png)

Önce Hub 'mızı oluşturduk Hub dan kastığımız yönlendirici kontrol eden virtual bilgisayar gibi düşünün 
(yada ağaç yapısındaki Root-Kök gibi)

Hub ayağa kalkınca http://localhost:4444   üzerinden kontrol edebilirsiniz(kendi fake Ip de üretiyor)

sonra 2. bir cmd ile Node oluşturacağız ve Node muzu Hub'a bağlayacağız

işlem bitince http://localhost:4444/grid/console dan bakabilirsiniz default olarak 11 adet browser sürümü ayakta,

node ları artırabilirsiniz tabi :)) 

