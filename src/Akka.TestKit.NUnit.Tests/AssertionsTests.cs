//-----------------------------------------------------------------------
// <copyright file="AssertionsTests.cs" company="Akka.NET Project">
//     Copyright (C) 2009-2016 Typesafe Inc. <http://www.typesafe.com>
//     Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
// </copyright>
//----------------------------------------------------------------------

using NUnit.Framework;

namespace Akka.TestKit.NUnit.Tests
{
    [Parallelizable(ParallelScope.All)]
    public class AssertionsTests : TestKit
    {
        private readonly NUnitAssertions _assertions = new();

        [Test]
        public void Fail_should_throw()
        {
            Assert.Throws<AssertionException>(() => _assertions.Fail());
        }

        [Test]
        public void AssertTrue_should_throw_on_false()
        {
            Assert.Throws<AssertionException>(() => _assertions.AssertTrue(false));
        }

        [Test]
        public void AssertTrue_should_succeed_on_true()
        {
            _assertions.AssertTrue(true);
        }

        [Test]
        public void AssertFalse_should_throw_on_true()
        {
            Assert.Throws<AssertionException>(() => _assertions.AssertFalse(true));
        }

        [Test]
        public void AssertFalse_should_succeed_on_false()
        {
            _assertions.AssertFalse(false);
        }

        [Test]
        public void AssertEqual_should_throw_on_not_equal()
        {
            Assert.Throws<AssertionException>(() => _assertions.AssertEqual(42, 4711));
        }

        [Test]
        public void AssertEqual_should_succeed_on_equal()
        {
            _assertions.AssertEqual(42, 42);
        }

        [Test]
        public void AssertEqualWithComparer_should_throw_on_not_equal()
        {
            Assert.Throws<AssertionException>(() => _assertions.AssertEqual(42, 42, (x, y) => false));
        }

        [Test]
        public void AssertEqualWithComparer_should_succeed_on_equal()
        {
            _assertions.AssertEqual(42, 4711, (x, y) => true);
        }

        [Test]
        public void Assert_should_not_format_message_when_no_arguments_are_specified()
        {
            const string testMessage = "{Value} with different format placeholders {0}";

            Assert.Multiple(() =>
            {
                Assert.That(
                    code: () => _assertions.Fail(testMessage),
                    constraint: Throws.Exception.TypeOf<AssertionException>().And.Message.Contains(testMessage));
                Assert.That(
                    code: () => _assertions.AssertTrue(false, testMessage),
                    constraint: Throws.Exception.TypeOf<AssertionException>().And.Message.Contains(testMessage));
                Assert.That(
                    code: () => _assertions.AssertFalse(true, testMessage),
                    constraint: Throws.Exception.TypeOf<AssertionException>().And.Message.Contains(testMessage));
                Assert.That(
                    code: () => _assertions.AssertEqual(4, 2, testMessage),
                    constraint: Throws.Exception.TypeOf<AssertionException>().And.Message.Contains(testMessage));
                Assert.That(
                    code: () => _assertions.AssertEqual(4, 2, (_, _) => false, testMessage),
                    constraint: Throws.Exception.TypeOf<AssertionException>().And.Message.Contains(testMessage));
            });
        }
    }
}
