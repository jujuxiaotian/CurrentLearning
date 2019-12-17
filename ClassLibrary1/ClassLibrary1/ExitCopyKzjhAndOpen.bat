@echo off
REM 声明采用UTF-8编码
chcp 65001
REM echo test
REM echo 中文测试
REM pause

taskkill /f /im "GSPMain.exe"

copy D:\My_JCData\Source\JD预算管理系统\Version_ZB\JC.YS.Kzjh\JC.YS.Ctl.Kzjh\bin\Debug\JC.YS.Ctl.Kzjh.dll D:\My_JD\总部测试_84\JC\JDCW\

start D:\My_JD\总部测试_84\JC\JDCW\GSFramework.exe