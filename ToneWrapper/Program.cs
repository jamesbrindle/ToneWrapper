using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToneWrapperApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tone = new ToneWrapper(@"E:\Downloads\Recursion-LC_128_44100_stereo.m4b");

            tone.Artist = "Blake Crouch";
            tone.Title = "Recursion";
            tone.OriginalAlbum = "Recursion";
            tone.AlbumArtist = "Blake Crouch";            
            tone.Genre = "Audiobook";
            tone.Comment = "Memory makes reality. That's what NYC cop Barry Sutton is learning, as he investigates the devastating phenomenon the media has dubbed False Memory Syndrome—a mysterious affliction that drives its victims mad with memories of a life they never lived. That's what neuroscientist Helena Smith believes. It's why she's dedicated her life to creating a technology that will let us preserve our most precious memories. If she succeeds, anyone will be able to re-experience a first kiss, the birth of a child, the final moment with a dying parent. As Barry searches for the truth, he comes face to face with an opponent more terrifying than any disease—a force that attacks not just our minds, but the very fabric of the past. And as its effects begin to unmake the world as we know it, only he and Helena, working together, will stand a chance at defeating it. But how can they make a stand when reality itself is shifting and crumbling all around them? At once a relentless pageturner and an intricate science-fiction puzzlebox about time, identity, and memory, Recursion is a thriller as only Blake Crouch could imagine it—and his most ambitious, mind-boggling, irresistible work to date.";
            tone.Description = "Memory makes reality. That's what NYC cop Barry Sutton is learning, as he investigates the devastating phenomenon the media has dubbed False Memory Syndrome—a mysterious affliction that drives its victims mad with memories of a life they never lived. That's what neuroscientist Helena Smith believes. It's why she's dedicated her life to creating a technology that will let us preserve our most precious memories. If she succeeds, anyone will be able to re-experience a first kiss, the birth of a child, the final moment with a dying parent. As Barry searches for the truth, he comes face to face with an opponent more terrifying than any disease—a force that attacks not just our minds, but the very fabric of the past. And as its effects begin to unmake the world as we know it, only he and Helena, working together, will stand a chance at defeating it. But how can they make a stand when reality itself is shifting and crumbling all around them? At once a relentless pageturner and an intricate science-fiction puzzlebox about time, identity, and memory, Recursion is a thriller as only Blake Crouch could imagine it—and his most ambitious, mind-boggling, irresistible work to date.";
            tone.Composer = "Jon Lindstrom;  Abby Craden";
            tone.Narrator = "Jon Lindstrom;  Abby Craden";
            tone.Copyright = "©2019 Blake Crouch (P)2019 Penguin Random House LLC";
            tone.TrackNumber = "1";
            tone.TrackTotal = "1";
            tone.SortAlbum = "Recursion";
            tone.RecordingDate = "01/01/2019";
            tone.AdditionalFieldsToAdd.Add(new ToneWrapper.AdditionalField("ASIN", "1509866701"));
            tone.AdditionalFieldsToAdd.Add(new ToneWrapper.AdditionalField("YEAR", "2019"));

            tone.WriteMetaData();
        }
    }
}
