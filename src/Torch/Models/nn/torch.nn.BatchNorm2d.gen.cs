// Code generated by CodeMinion: https://github.com/SciSharp/CodeMinion

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Python.Runtime;
using Numpy;
using Numpy.Models;

namespace Torch
{
    public static partial class torch {
        public static partial class nn {
            /// <summary>
            ///	Applies Batch Normalization over a 4D input (a mini-batch of 2D inputs
            ///	with additional channel dimension) as described in the paper
            ///	Batch Normalization: Accelerating Deep Network Training by Reducing Internal Covariate Shift .
            ///	
            ///	\[y = \frac{x - \mathrm{E}[x]}{ \sqrt{\mathrm{Var}[x] + \epsilon}} * \gamma + \beta\]
            ///	
            ///	The mean and standard-deviation are calculated per-dimension over
            ///	the mini-batches and \(\gamma\) and \(\beta\) are learnable parameter vectors
            ///	of size C (where C is the input size).<br></br>
            ///	 By default, the elements of \(\gamma\) are sampled
            ///	from \(\mathcal{U}(0, 1)\) and the elements of \(\beta\) are set to 0.<br></br>
            ///	
            ///	Also by default, during training this layer keeps running estimates of its
            ///	computed mean and variance, which are then used for normalization during
            ///	evaluation.<br></br>
            ///	 The running estimates are kept with a default momentum
            ///	of 0.1.
            ///	
            ///	If track_running_stats is set to False, this layer then does not
            ///	keep running estimates, and batch statistics are instead used during
            ///	evaluation time as well.<br></br>
            ///	
            ///	Note
            ///	This momentum argument is different from one used in optimizer
            ///	classes and the conventional notion of momentum.<br></br>
            ///	 Mathematically, the
            ///	update rule for running statistics here is
            ///	\(\hat{x}_\text{new} = (1 - \text{momentum}) \times \hat{x} + \text{momentum} \times x_t\),
            ///	where \(\hat{x}\) is the estimated statistic and \(x_t\) is the
            ///	new observed value.<br></br>
            ///	
            ///	Because the Batch Normalization is done over the C dimension, computing statistics
            ///	on (N, H, W) slices, it’s common terminology to call this Spatial Batch Normalization.
            /// </summary>
            public partial class BatchNorm2d : Module
            {
                // auto-generated class
                
                public BatchNorm2d(PyObject pyobj) : base(pyobj) { }
                
                public BatchNorm2d(Module other) : base(other.PyObject as PyObject) { }
                
                public BatchNorm2d(int num_features, double eps = 1.0e-5, double? momentum = 0.1, bool affine = true, bool track_running_stats = true)
                {
                    //auto-generated code, do not change
                    var nn = self.GetAttr("nn");
                    var __self__=nn;
                    var pyargs=ToTuple(new object[]
                    {
                        num_features,
                    });
                    var kwargs=new PyDict();
                    if (eps!=1.0e-5) kwargs["eps"]=ToPython(eps);
                    if (momentum!=0.1) kwargs["momentum"]=ToPython(momentum);
                    if (affine!=true) kwargs["affine"]=ToPython(affine);
                    if (track_running_stats!=true) kwargs["track_running_stats"]=ToPython(track_running_stats);
                    dynamic py = __self__.InvokeMethod("BatchNorm2d", pyargs, kwargs);
                    self=py as PyObject;
                }
                
            }
        }
    }
    
}
