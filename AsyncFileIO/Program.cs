using System;
using System.IO;
using System.Threading.Tasks;

namespace AsyncFileIO
{
    class MainApp
    {
        // 파일 복사 후 복사한 파일 용량 반환.
        static async Task<long> CopyAsync(string FromPath, string ToPath)
        {
            using (
                var fromStream = new FileStream(FromPath, FileMode.Open))
            {
                long totalCopied = 0;

                using (
                    )
            }
        }
    }
}
