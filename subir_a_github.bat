@echo off
REM === CONFIGURA ESTOS CAMPOS ANTES DE USAR ===
set REPO_URL=https://github.com/Fvasquez2556/VentasWeb.git
set COMMIT_MSG=Subida inicial del proyecto VentasWeb

REM === INICIO ===

echo Inicializando repositorio...
git init

echo Creando .gitignore...
echo bin/>> .gitignore
echo obj/>> .gitignore
echo .vs/>> .gitignore
echo *.user>> .gitignore
echo *.suo>> .gitignore
echo .vscode/>> .gitignore
echo *.log>> .gitignore
echo *.db>> .gitignore
echo node_modules/>> .gitignore

echo Agregando archivos...
git add .

echo Commit...
git commit -m "%COMMIT_MSG%"

echo Configurando repositorio remoto...
git remote add origin %REPO_URL%

echo Subiendo al repositorio remoto...
git branch -M main
git push -u origin main

pause
