# HostedNetworkWinForm

Для работы приложения необходим .net framework 4.5 (при необходимости качаем с Microsoft.com и устанавливаем)

Приложение 100% работает на Windows 7, должно работать и на Windows 8, 8.1, 10
На Windows XP и более ранних работать не будет.

Для того чтобы разрешить использование программной точки доступа нужно нажать кнопку "Update settings", 
      в открывшемся окне (Settings) нажать кнопку "Allow". (выполнится команда "netsh wlan set hostednetwork mode=allow")
      В последующем, для запрещения запуска программной точки доступа здесь же нужно нажать кнопку "Disallow". 
      (выполнится команда "netsh wlan set hostednetwork mode=disallow")
Для того чтобы ззадать SSID и ключ сети в окне Settings (переход из главного окна по кнопке "Update settings") нужно ввести
      желаемые значения в поля SSID и Key, после чего нажать "OK". 
      (выполнится команда "netsh wlan set hostednetwork ssid="ваш SSID" key="ваш ключ", окно "Settings" закроется)
      Для ввода доступны цыфры и латиница, длина ключа не может быть меньше 8 символов.
Для запуска программной точки доступа нажмите кнопку "Start hosted network". (выполнится команда "netsh wlan start hostednetwork")
Для остановки программной точки доступа нажмите кнопку "Stop hosted network". (выполнится команда "netsh wlan stop hostednetwork")

Введённые ранее через это приложение SSID и Key будут отображаться в соответствующих полях в окне "Settings" 
      (если не удалять файл HostedNetworkForm.settings, лежащий вместе с приложением)
      
Для того чтобы программная точка доступа раздавала интернет нужно перейти в центр управления сетями и общим доступом и расшарить интернет 
      (выбрать сеть дающую доступ к интернету, кликнуть кнопку "Свойства", затем вкладку "Доступ", установить флажок "Разрешить другим
      пользователям сети использовать подключение к интернету данного компьютера" и указать созданную сеть 
      (у меня это "Беспроводное сетевое соединение 2"))
      
В будущем планирую сделать инсталлятор, а пока рекомендую класть приложение в отдельную директорию в любом удобном для вас месте 
      (я у себя положил в ProgramFiles в папку "HostedNetworkForm") и делать ярлык на рабочем столе и/или на панели быстрого запуска.
      
Приятного использования!
