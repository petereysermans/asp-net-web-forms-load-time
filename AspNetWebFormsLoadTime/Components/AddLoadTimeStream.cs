using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Web;

namespace AspNetWebFormsLoadTime.Components
{
    public class AddLoadTimeStream : Stream
    {
        private readonly Stream _baseStream;

        public AddLoadTimeStream(Stream responseStream)
        {
            _baseStream = responseStream;
        }

        public override bool CanRead
        {
            get { return _baseStream.CanRead; }
        }

        public override bool CanSeek
        {
            get { return _baseStream.CanSeek; }
        }

        public override bool CanWrite
        {
            get { return _baseStream.CanWrite; }
        }

        public override long Length
        {
            get { return _baseStream.Length; }
        }

        public override long Position { get; set; }

        public override void Flush()
        {
            _baseStream.Flush();
        }

        public override long Seek(
            long offset,
            SeekOrigin origin)
        {
            return _baseStream.Seek(offset, origin);
        }

        public override void SetLength(long value)
        {
            _baseStream.SetLength(value);
        }

        public override int Read(
            byte[] buffer,
            int offset,
            int count)
        {
            return _baseStream.Read(buffer, offset, count);
        }

        public override void Write(
            byte[] buffer,
            int offset,
            int count)
        {
            string originalText = Encoding.UTF8.GetString(buffer,
               offset, count);

            var begin = (DateTime)HttpContext.Current.Items["StartTime"];
            var end = DateTime.UtcNow;
            var formattedTimeElapsed = (((end - begin).TotalMilliseconds) / 1000).ToString(CultureInfo.InvariantCulture);

            originalText = originalText.Replace("##load_time##", formattedTimeElapsed);

            buffer = Encoding.UTF8.GetBytes(originalText);
            
            _baseStream.Write(buffer, 0, buffer.Length);
        }
    }
}