# ExcelCmd
エクセルから、標準入出力をやり取りするコンソールアプリを起動してデータをやり取りするチップス<br>

<h3>格納ファイルの説明</h3>
<dl>
<dt>
consTest\
</dt>
<dd>: コンソールアプリのサンプル（Visual Stduio Comunity 2017) 言語：C# <br>
　　ーー＞　標準入力から文字列1行取得し、逆順にして標準出力に返す<br>
</dd>
<dt>
ExcelCmd.xlsm
</dt>
<dd>
：エクセルマクロによるGUI<br>
　　ーー＞　上記コンソールアプリに、標準入力で文字列を与え、結果を取得する
 </dd>
 <dt>
 Module1.bas
 </dt>
 <dd>：　エクセルVBAのサンプルコード
 </dd>
  <h3>インターフェイスの説明</h3>
  
 <dl>
  <dt>標準入力</dt>
  <dd>コンソールアプリケーションに於いて、ユーザがキーボードでプログラムに入力した値や文字列<br>
    VBAが、プログラムに書き込む値。
    <ul>
      <li> C言語：scanf(), fscanf(stdin,...) など</li>
      <li> .Net(C#) : Console.ReadLine(), Console.Read()</li>
      <li> VBA  : [WshScriptExecオブジェクト].StdIn.WriteLine など</li>
   </ul>
  </dd>
  <dt>標準出力</dt>
  <dd>コンソールアプリケーションに於いて、プログラムが、コンソール画面に出力する文字列<br>
    VBAが、プログラムから読み込む値。
    <ul>
      <li>C言語：printf(), fputs(stdout,..) など</li>
      <li>.Net(C#): Console.WriteLine(), Console.Write()</li>
      <li>VBA :  [WshScriptExecオブジェクト].StdOut.ReadAll など</li>
    </ul>
   </dd>
  <dt>標準エラー</dt>
  <dd>コンソールアプリケーションに於いて、プログラムが、エラーを通知する。通常は取得しない。<br>
    <ul>
      <li>C言語：fputs(stderr,...), fprintf(stderr,...)など</li>
      <li>.Net(C#): Console.Error.WriteLine() など</li>
      <li>VBA :  [WshScriptExecオブジェクト].StdErr.ReadAll など</li>
    </ul>
  </dd>
  <dt>プログラム戻り値</dt>
  <dd>プログラムが終了するときに、ホストに通知する整数値。通常0を返す<br>
    <ul>
      <li>C言語：　<br>
<pre>
<b>int</b> main(void){ 
    return <b>0</b>;
}</pre>
</li>
       <li>.Net(C#):<br>
<pre>
static <b>int</b> Main(string[] args)|
    return <b>0</b>;
}
</pre>
         </li>
     <li>VB.net<br>
<pre>
<b>Function</b> Main() <b>As Integer</b>
    Return <b>0</b>
End <b>Function</b>
</pre>
      </li>
      <li>.Net(共通)<br>
        System.Environment.ExitCode = <b>0</b><br>
        (Main関数が、void型や、Subルーチンでも使用可能)
      </li>
      <li>VBA :  [WshScriptExecオブジェクト].ExitCode
      </li>
    </ul>
  </dd>
