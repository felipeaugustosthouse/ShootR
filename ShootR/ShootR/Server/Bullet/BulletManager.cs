﻿using System.Collections.Generic;

namespace ShootR
{
    /// <summary>
    /// Used to monitor all bullets on the game field.
    /// </summary>
    public class BulletManager
    {
        // Having an int GUID to reduce payload size
        private static int _bulletGUID = 0;

        public BulletManager()
        {
            Bullets = new List<Bullet>();
        }

        public void Add(Bullet bullet)
        {
            bullet.ID = _bulletGUID++;
            Bullets.Add(bullet);
        }

        public List<Bullet> Bullets { get; set; }

        public void Update(GameTime gameTime)
        {
            for (int i = 0; i < Bullets.Count; i++)
            {
                if (Bullets[i].ShouldDispose())
                {
                    Bullets[i].Dispose();
                    Bullets.Remove(Bullets[i--]);
                }
                else if (Bullets[i].Disposed)
                {
                    Bullets.Remove(Bullets[i--]);
                }
                else
                {
                    Bullets[i].Update(gameTime);
                }
            }
        }
    }
}