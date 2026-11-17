@echo off
rem ==============================================================
rem  MERCADINHO BRASIL - Cria o banco de dados no PostgreSQL
rem
rem  Basta dar dois cliques neste arquivo.
rem  Ele vai pedir a senha do usuario "postgres" duas vezes
rem  (a senha que voce escolheu quando instalou o PostgreSQL).
rem  A senha nao aparece na tela enquanto voce digita, e normal.
rem ==============================================================

set PSQL="C:\Program Files\PostgreSQL\18\bin\psql.exe"

echo.
echo [1/2] Criando o banco "mercadinho_brasil"...
echo       (se ele ja existir, vai aparecer um erro aqui. Pode ignorar.)
%PSQL% -U postgres -h localhost -c "CREATE DATABASE mercadinho_brasil"

echo.
echo [2/2] Criando as tabelas e os produtos de exemplo...
%PSQL% -U postgres -h localhost -d mercadinho_brasil -f "%~dp0mercadinho_brasil.sql"

echo.
echo Pronto! Se nao apareceu nenhum erro acima, o banco esta criado.
echo.
pause
