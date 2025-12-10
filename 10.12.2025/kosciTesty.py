import unittest
from kosci import calculate_score

class TestowanieKosci(unittest.TestCase):
    def poprawnosc_losowania(self):
        self.assertTrue(calculate_score([1,2,3,4,5,6])==0)

if __name__ == '__main__':
    unittest.main()