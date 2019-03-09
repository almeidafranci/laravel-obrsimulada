<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="utf-8">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8">
    <title>OBR Simulada</title>
    <script src="{{ asset('/vendor/obrsimulada/Build/UnityLoader.js') }}"></script>
    <script>
        var gameInstance = UnityLoader.instantiate("gameContainer", "{{ asset('/vendor/obrsimulada/Build/obrs-web.json') }}");
    </script>
</head>
<body>
<center>
    <div id="gameContainer" style="width: 960px; height: 600px; margin: auto"></div>
</center>
</body>
</html>
