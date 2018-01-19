Add-Type -Assembly "System.IO.Compression.FileSystem" ;
[System.IO.Compression.ZipFile]::CreateFromDirectory("C:\Dados\Curl", "C:\Dados\archive.zip")