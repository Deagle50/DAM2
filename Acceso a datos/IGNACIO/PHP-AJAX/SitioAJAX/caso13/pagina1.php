<?php
  header('Content-Type: text/html; charset=utf-8');
  if ($_REQUEST['cod']=='c1')
  {
    echo "<p>Primer tooltip.</p>";
    echo "<p>aaaaaaaaaaaaaaaaaaa aaaaaaaaaaaaaaaaaaaaaa aaaaaa aaaaaaaaaa";
    echo "aaaaaaaaaaaaaaaaaaa aaaaaaaaa aaaaaaaaaaaaa aaaaaaaaaaaaaaaa";
    echo "aaaaaaaaaaaaaaaaaaa aaaaaaaa aaaaaaaaaaaaaa aaaaaaaaa aaaaaaa";
    echo "aaaaaaaaaaaaaa aaaaa aaaaaaaaaaaaaaaaaaaaaa aaaaaa aaaaaaaaaa";
    echo "aaaaaaaaaaaaaaaaaaa aaaaaaaaaaaaaaa aaaaaaa aaaaaaaaaaaaaaaa</p>";
  }
  if ($_REQUEST['cod']=='c2')
  {    
    echo "<p>Segundo tooltip.</p>";
    echo "<p>bbbbbbbb bbbbbbbbbbb bbbbbbbb bbbbbbbbbbbbbb bbbbbbbbbbb bb";
    echo "bbbbbbbb bbbbbbbbbb bbbbbbbbbbbb bbbbbbbbbb bbbbbbbbbbb bbb</p>";
  }
  if ($_REQUEST['cod']=='c3')
    echo "<p>Tercer tooltip.</p>";
  if ($_REQUEST['cod']=='c4')
    echo "<p>Cuarto tooltip.</p>";
?>