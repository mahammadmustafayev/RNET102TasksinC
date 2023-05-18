using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.Models
{
    internal class Weapon
    {
        private int _bulletCapacity;
        private int _currentBulletCapacity;
        private bool _fireMode;
        private double _dischargeSecond;
        public int BulletCapacity 
        { 
            get 
            {
                return _bulletCapacity;
            } 
            set 
            {
                if (value>0 && value<=100)
                {
                    _bulletCapacity = value;
                }
            } 
        }
        public int CurrentBulletCapacity 
        { 
            get 
            {
                return _currentBulletCapacity;
            }
            set 
            {
                if (value>0 && value<=_bulletCapacity)
                {
                    _currentBulletCapacity = value;
                }
            } 
        }
        public double DischargeSecond 
        { 
            get 
            {
                return _dischargeSecond;
            }
            set 
            {
                if (value>0&& value<=60)
                {
                    _dischargeSecond = value;
                }
            }
        }
        public bool FireMode 
        { 
            get 
            {
                return _fireMode;
            } 
            set 
            {
                if (value==true||value==false)
                {
                    _fireMode = value;
                }
            } 
        }

        public void Shoot()
        {
            if (_currentBulletCapacity>0)
            {
                _currentBulletCapacity--;
                Console.WriteLine("1 gulle atildi");
                Console.WriteLine($"Geri qalan gulle sayi:{_currentBulletCapacity}");
            }
            else
            {
                Console.WriteLine("Sizin silahinizda gulle yoxdur");
            }
        }
        public void Fire()
        {
            if (_currentBulletCapacity>0)
            {
                if (_fireMode == true)
                {
                    double time = 0.1;
                    _dischargeSecond=time*_currentBulletCapacity;
                    _currentBulletCapacity=0;
                    Console.WriteLine($"Silahdaki butun gullenin bitme saniyesi {Math.Round(_dischargeSecond)}");
                }
                else
                {
                    _currentBulletCapacity--;
                    Console.WriteLine("1 gulle atildi");
                    Console.WriteLine($"Geri qalan gulle sayi:{_currentBulletCapacity}");
                }
            }
            else
            {
                Console.WriteLine("Sizin silahinizda gulle yoxdur");
            }
        }
        public int GetRemainBulletCount()
        {
            return _bulletCapacity - _currentBulletCapacity;
        }
        public void Reload()
        {
            if (_bulletCapacity!=_currentBulletCapacity)
            {
                int needBullet = GetRemainBulletCount();
                _currentBulletCapacity += needBullet;
                Console.WriteLine("Daraqdaki yeniden dolduruldu");
            }
            else
            {
                Console.WriteLine("Daraq onsuzda doludur");
            }
        }
        public void ChangeFireMode()
        {
            if (_fireMode==true)
            {
                _fireMode = false;
            }
            else
            {
                _fireMode=true;
            }
        }
    }
}
