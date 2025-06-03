:: リリースビルドでパブリッシュ
dotnet publish -c Release

:: パブリッシュされた exe ファイルをカレントディレクトリにコピー
copy ".\bin\Release\net9.0\win-x64\publish\*.exe" ".\"


:: bin と obj フォルダを削除
::rmdir /s /q ".\bin"
::rmdir /s /q ".\obj"

pause