<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        N: <input type="text" name="num" />
        <input type="submit" />
    </form>
    <?php
    if (isset($_GET['num'])){
        $number = intval($_GET['num']);
        $f0 = 0;
        $f1 = 1;
        $f2 = 1;
        echo $f0 . ' ' . $f1 . ' ' . $f2 . ' ';
        for ($i = 2; $i < $number; $i++){
            $fNext = $f0 + $f1 + $f2;
            $f0 = $f1;
            $f1 = $f2;
            $f2 = $fNext;
            echo $f2 . ' ';
        }
    }
    ?>
</body>
</html>