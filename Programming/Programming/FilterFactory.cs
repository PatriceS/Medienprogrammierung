using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Programming
{
    class FilterFactory : ManipulationFactory
    {
        public override Manipulate create(ImageManipulatorType.Name name, Bitmap bitmap, System.IntPtr Scan0, int stride, int height_start, int height_end, ThreadHandler thHandler, int[] values)
        {
            switch (name)
            {
                case ImageManipulatorType.Name.INVERT:
                    return new InvertFilter(bitmap, Scan0, stride, height_start, height_end, thHandler, values);
                    break;


                case ImageManipulatorType.Name.OSCILLATION:
                    return new OscillationFilter(bitmap, Scan0, stride, height_start, height_end, thHandler, values);
                   
                    break;

                case ImageManipulatorType.Name.GRAYSCALE:
                    return new GrayscaleFilter(bitmap, Scan0, stride, height_start, height_end, thHandler, values);
                    
                    break;
                case ImageManipulatorType.Name.BLACKWHITE:
                    return new BlackWhiteFilter(bitmap, Scan0, stride, height_start, height_end, thHandler, values);
                    
                    break;
                case ImageManipulatorType.Name.ERROR_DIFFUSION:
                    return new ErrorDiffusionFilter(bitmap, Scan0, stride, height_start, height_end, thHandler, values);
                    
                    break;
                case ImageManipulatorType.Name.SEPIA:
                    return new SepiaFilter(bitmap, Scan0, stride, height_start, height_end, thHandler, values);
                    
                    break;
                case ImageManipulatorType.Name.SAMPLE_BOARD:
                    return new SampleBoardFilter(bitmap, Scan0, stride, height_start, height_end, thHandler, values);
                    
                    break;
                case ImageManipulatorType.Name.RGB_RED:
                    return new RGB_ModeFilter(bitmap, Scan0, stride, height_start, height_end, thHandler, ImageManipulatorType.Name.RGB_RED);

                  
                    break;
                case ImageManipulatorType.Name.RGB_GREEN:
                    return new RGB_ModeFilter(bitmap, Scan0, stride, height_start, height_end, thHandler, ImageManipulatorType.Name.RGB_GREEN);

                    break;
                case ImageManipulatorType.Name.RGB_BLUE:
                    return new RGB_ModeFilter(bitmap, Scan0, stride, height_start, height_end, thHandler, ImageManipulatorType.Name.RGB_BLUE);
                   
                    break;

            //    default:


              
            }

            return new InvertFilter(bitmap, Scan0, stride, height_start, height_end, thHandler, values);
        }

    }
}
