# PHP-Downloader
PHP下载器,PHP断点下载,PHP下载远程文件,支持断点下载。

<table border="1">
    <tr>
        <td>支持的运行方式</td>
        <td>下载速度比较慢</td>
        <td>是否支持多线程</td>
    </tr>
    <tr>
        <td>fpm/cli</td>
        <td>建议调整分片大小</td>
        <td>不支持,可以自己扩展,将每个分片范围通过curl批量请求实现</td>
    </tr>
</table>
提示:

fpm环境下载,由于fpm下php存在运行时间限制导致执行一会儿就会停止下载，可以多次执行访问脚本，每次会从上一次下载的地方继续选择。内部已经做文件锁处理，频繁访问url脚本不影响。
