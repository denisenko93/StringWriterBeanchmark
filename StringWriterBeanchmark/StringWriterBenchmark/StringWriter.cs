﻿using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StringWriterBeanchmark;

// This class implements a text writer that writes to a string buffer and allows
    // the resulting sequence of characters to be presented as a string.
    public class StringWriter : TextWriter
    {
        private static volatile UnicodeEncoding? s_encoding;

        private readonly StringBuilder _sb;
        private bool _isOpen;

        // Constructs a new StringWriter. A new StringBuilder is automatically
        // created and associated with the new StringWriter.
        public StringWriter()
            : this(new StringBuilder(), CultureInfo.CurrentCulture)
        {
        }

        public StringWriter(IFormatProvider? formatProvider)
            : this(new StringBuilder(), formatProvider)
        {
        }

        // Constructs a new StringWriter that writes to the given StringBuilder.
        //
        public StringWriter(StringBuilder sb) : this(sb, CultureInfo.CurrentCulture)
        {
        }

        public StringWriter(StringBuilder sb!!, IFormatProvider? formatProvider) : base(formatProvider)
        {
            _sb = sb;
            _isOpen = true;
        }

        public override void Close()
        {
            Dispose(true);
        }

        protected override void Dispose(bool disposing)
        {
            // Do not destroy _sb, so that we can extract this after we are
            // done writing (similar to MemoryStream's GetBuffer & ToArray methods)
            _isOpen = false;
            base.Dispose(disposing);
        }


        public override Encoding Encoding
        {
            get
            {
                if (s_encoding == null)
                {
                    s_encoding = new UnicodeEncoding(false, false);
                }
                return s_encoding;
            }
        }

        // Returns the underlying StringBuilder. This is either the StringBuilder
        // that was passed to the constructor, or the StringBuilder that was
        // automatically created.
        //
        public virtual StringBuilder GetStringBuilder()
        {
            return _sb;
        }

        // Writes a character to the underlying string buffer.
        //
        public override void Write(char value)
        {
            if (!_isOpen)
            {
                throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
            }

            _sb.Append(value);
        }

        // Writes a range of a character array to the underlying string buffer.
        // This method will write count characters of data into this
        // StringWriter from the buffer character array starting at position
        // index.
        //
        public override void Write(char[] buffer!!, int index, int count)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(index), SR.ArgumentOutOfRange_NeedNonNegNum);
            }
            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), SR.ArgumentOutOfRange_NeedNonNegNum);
            }
            if (buffer.Length - index < count)
            {
                throw new ArgumentException(SR.Argument_InvalidOffLen);
            }
            if (!_isOpen)
            {
                throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
            }

            _sb.Append(buffer, index, count);
        }

        public override void Write(ReadOnlySpan<char> buffer)
        {
            if (GetType() != typeof(StringWriter))
            {
                // This overload was added after the Write(char[], ...) overload, and so in case
                // a derived type may have overridden it, we need to delegate to it, which the base does.
                base.Write(buffer);
                return;
            }

            if (!_isOpen)
            {
                throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
            }

            _sb.Append(buffer);
        }

        // Writes a string to the underlying string buffer. If the given string is
        // null, nothing is written.
        //
        public override void Write(string? value)
        {
            if (!_isOpen)
            {
                throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
            }

            if (value != null)
            {
                _sb.Append(value);
            }
        }

        public override void Write(StringBuilder? value)
        {
            if (GetType() != typeof(StringWriter))
            {
                // This overload was added after the Write(char[], ...) overload, and so in case
                // a derived type may have overridden it, we need to delegate to it, which the base does.
                base.Write(value);
                return;
            }

            if (!_isOpen)
            {
                throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
            }

            _sb.Append(value);
        }

        public override void Write(int value)
        {
            if (GetType() != typeof(StringWriter))
            {
                // This overload was added after the Write(char[], ...) overload, and so in case
                // a derived type may have overridden it, we need to delegate to it, which the base does.
                base.Write(value);
                return;
            }

            if (!_isOpen)
            {
                throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
            }

            _sb.Append(value);
        }

        public override void Write(uint value)
        {
            if (GetType() != typeof(StringWriter))
            {
                // This overload was added after the Write(char[], ...) overload, and so in case
                // a derived type may have overridden it, we need to delegate to it, which the base does.
                base.Write(value);
                return;
            }

            if (!_isOpen)
            {
                throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
            }

            _sb.Append(value);
        }

        public override void Write(long value)
        {
            if (GetType() != typeof(StringWriter))
            {
                // This overload was added after the Write(char[], ...) overload, and so in case
                // a derived type may have overridden it, we need to delegate to it, which the base does.
                base.Write(value);
                return;
            }

            if (!_isOpen)
            {
                throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
            }

            _sb.Append(value);
        }

        public override void Write(ulong value)
        {
            if (GetType() != typeof(StringWriter))
            {
                // This overload was added after the Write(char[], ...) overload, and so in case
                // a derived type may have overridden it, we need to delegate to it, which the base does.
                base.Write(value);
                return;
            }

            if (!_isOpen)
            {
                throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
            }

            _sb.Append(value);
        }

        public override void Write(decimal value)
        {
            if (GetType() != typeof(StringWriter))
            {
                // This overload was added after the Write(char[], ...) overload, and so in case
                // a derived type may have overridden it, we need to delegate to it, which the base does.
                base.Write(value);
                return;
            }

            if (!_isOpen)
            {
                throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
            }

            _sb.Append(value);
        }

        public override void Write(double value)
        {
            if (GetType() != typeof(StringWriter))
            {
                // This overload was added after the Write(char[], ...) overload, and so in case
                // a derived type may have overridden it, we need to delegate to it, which the base does.
                base.Write(value);
                return;
            }

            if (!_isOpen)
            {
                throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
            }

            _sb.Append(value);
        }

        public override void Write(float value)
        {
            if (GetType() != typeof(StringWriter))
            {
                // This overload was added after the Write(char[], ...) overload, and so in case
                // a derived type may have overridden it, we need to delegate to it, which the base does.
                base.Write(value);
                return;
            }

            if (!_isOpen)
            {
                throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
            }

            _sb.Append(value);
        }

        public override void Write(object? value)
        {
            if (GetType() != typeof(StringWriter))
            {
                // This overload was added after the Write(char[], ...) overload, and so in case
                // a derived type may have overridden it, we need to delegate to it, which the base does.
                base.Write(value);
                return;
            }

            if (!_isOpen)
            {
                throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
            }

            _sb.Append(value);
        }

        public override void Write(string format, object? arg0)
        {
            if (GetType() != typeof(StringWriter))
            {
                // This overload was added after the Write(char[], ...) overload, and so in case
                // a derived type may have overridden it, we need to delegate to it, which the base does.
                base.Write(format, arg0);
                return;
            }

            if (!_isOpen)
            {
                throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
            }

            _sb.AppendFormat(format, arg0);
        }

        public override void Write(string format, object? arg0, object? arg1)
        {
            if (GetType() != typeof(StringWriter))
            {
                // This overload was added after the Write(char[], ...) overload, and so in case
                // a derived type may have overridden it, we need to delegate to it, which the base does.
                base.Write(format, arg0, arg1);
                return;
            }

            if (!_isOpen)
            {
                throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
            }

            _sb.AppendFormat(format, arg0, arg1);
        }

        public override void Write(string format, object? arg0, object? arg1, object? arg2)
        {
            if (GetType() != typeof(StringWriter))
            {
                // This overload was added after the Write(char[], ...) overload, and so in case
                // a derived type may have overridden it, we need to delegate to it, which the base does.
                base.Write(format, arg0, arg1, arg2);
                return;
            }

            if (!_isOpen)
            {
                throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
            }

            _sb.AppendFormat(format, arg0, arg1, arg2);
        }

        public override void Write(string format, params object?[] arg)
        {
            if (GetType() != typeof(StringWriter))
            {
                // This overload was added after the Write(char[], ...) overload, and so in case
                // a derived type may have overridden it, we need to delegate to it, which the base does.
                base.Write(format, arg);
                return;
            }

            if (!_isOpen)
            {
                throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
            }

            _sb.AppendFormat(format, arg);
        }

        public override void WriteLine(object? value)
        {
            if (GetType() != typeof(StringWriter))
            {
                // This overload was added after the Write(char[], ...) overload, and so in case
                // a derived type may have overridden it, we need to delegate to it, which the base does.
                base.WriteLine(value);
                return;
            }

            if (!_isOpen)
            {
                throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
            }

            _sb.Append(value);
            WriteLine();
        }

        public override void WriteLine(string format, object? arg0)
        {
            if (GetType() != typeof(StringWriter))
            {
                // This overload was added after the Write(char[], ...) overload, and so in case
                // a derived type may have overridden it, we need to delegate to it, which the base does.
                base.WriteLine(format, arg0);
                return;
            }

            if (!_isOpen)
            {
                throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
            }

            _sb.AppendFormat(format, arg0);
            WriteLine();
        }

        public override void WriteLine(string format, object? arg0, object? arg1)
        {
            if (GetType() != typeof(StringWriter))
            {
                // This overload was added after the Write(char[], ...) overload, and so in case
                // a derived type may have overridden it, we need to delegate to it, which the base does.
                base.WriteLine(format, arg0, arg1);
                return;
            }

            if (!_isOpen)
            {
                throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
            }

            _sb.AppendFormat(format, arg0, arg1);
            WriteLine();
        }

        public override void WriteLine(string format, object? arg0, object? arg1, object? arg2)
        {
            if (GetType() != typeof(StringWriter))
            {
                // This overload was added after the Write(char[], ...) overload, and so in case
                // a derived type may have overridden it, we need to delegate to it, which the base does.
                base.WriteLine(format, arg0, arg1, arg2);
                return;
            }

            if (!_isOpen)
            {
                throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
            }

            _sb.AppendFormat(format, arg0, arg1, arg2);
            WriteLine();
        }

        public override void WriteLine(string format, params object?[] arg)
        {
            if (GetType() != typeof(StringWriter))
            {
                // This overload was added after the Write(char[], ...) overload, and so in case
                // a derived type may have overridden it, we need to delegate to it, which the base does.
                base.WriteLine(format, arg);
                return;
            }

            if (!_isOpen)
            {
                throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
            }

            _sb.AppendFormat(format, arg);
            WriteLine();
        }

        public override void WriteLine(ReadOnlySpan<char> buffer)
        {
            if (GetType() != typeof(StringWriter))
            {
                // This overload was added after the WriteLine(char[], ...) overload, and so in case
                // a derived type may have overridden it, we need to delegate to it, which the base does.
                base.WriteLine(buffer);
                return;
            }

            if (!_isOpen)
            {
                throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
            }

            _sb.Append(buffer);
            WriteLine();
        }

        public override void WriteLine(StringBuilder? value)
        {
            if (GetType() != typeof(StringWriter))
            {
                // This overload was added after the WriteLine(char[], ...) overload, and so in case
                // a derived type may have overridden it, we need to delegate to it, which the base does.
                base.WriteLine(value);
                return;
            }

            if (!_isOpen)
            {
                throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
            }

            _sb.Append(value);
            WriteLine();
        }

        #region Task based Async APIs

        public override Task WriteAsync(char value)
        {
            Write(value);
            return Task.CompletedTask;
        }

        public override Task WriteAsync(string? value)
        {
            Write(value);
            return Task.CompletedTask;
        }

        public override Task WriteAsync(char[] buffer, int index, int count)
        {
            Write(buffer, index, count);
            return Task.CompletedTask;
        }

        public override Task WriteAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = default)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                return Task.FromCanceled(cancellationToken);
            }

            Write(buffer.Span);
            return Task.CompletedTask;
        }

        public override Task WriteAsync(StringBuilder? value, CancellationToken cancellationToken = default)
        {
            if (GetType() != typeof(StringWriter))
            {
                // This overload was added after the WriteAsync(char[], ...) overload, and so in case
                // a derived type may have overridden it, we need to delegate to it, which the base does.
                return base.WriteAsync(value, cancellationToken);
            }

            if (cancellationToken.IsCancellationRequested)
            {
                return Task.FromCanceled(cancellationToken);
            }

            if (!_isOpen)
            {
                throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
            }

            _sb.Append(value);
            return Task.CompletedTask;
        }

        public override Task WriteLineAsync()
        {
            return base.WriteLineAsync();
        }

        public override Task WriteLineAsync(char value)
        {
            WriteLine(value);
            return Task.CompletedTask;
        }

        public override Task WriteLineAsync(string? value)
        {
            WriteLine(value);
            return Task.CompletedTask;
        }

        public override Task WriteLineAsync(StringBuilder? value, CancellationToken cancellationToken = default)
        {
            if (GetType() != typeof(StringWriter))
            {
                // This overload was added after the WriteLineAsync(char[], ...) overload, and so in case
                // a derived type may have overridden it, we need to delegate to it, which the base does.
                return base.WriteLineAsync(value, cancellationToken);
            }

            if (cancellationToken.IsCancellationRequested)
            {
                return Task.FromCanceled(cancellationToken);
            }

            if (!_isOpen)
            {
                throw new ObjectDisposedException(null, SR.ObjectDisposed_WriterClosed);
            }

            _sb.Append(value);
            WriteLine();
            return Task.CompletedTask;
        }

        public override Task WriteLineAsync(char[] buffer, int index, int count)
        {
            WriteLine(buffer, index, count);
            return Task.CompletedTask;
        }

        public override Task WriteLineAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = default)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                return Task.FromCanceled(cancellationToken);
            }

            WriteLine(buffer.Span);
            return Task.CompletedTask;
        }

        public override Task FlushAsync()
        {
            return Task.CompletedTask;
        }

        #endregion

        // Returns a string containing the characters written to this TextWriter so far.
        public override string ToString()
        {
            return _sb.ToString();
        }
    }