@echo off
title Quitter Windate?
echo Quitter Windate? N'utilisez qu'en cas urgent. Votre ordinateur risque de courrir des dangers.
pause
taskkill /f /im windate.exe /t
pause
exit